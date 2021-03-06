﻿using iNeedTickets.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using iNeedTickets.Repos;
using iNeedTickets.Services;
using System.Web;

namespace iNeedTickets.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private ITicketRepository _ticketRepository;
        private RoleManager<IdentityRole> _roleManager;
        private IEmailService _emailService;

        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManager,
            ITicketRepository ticketRepository,
            RoleManager<IdentityRole> roleManager,
            IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _ticketRepository = ticketRepository;
            _roleManager = roleManager;
            _emailService = emailService;
        }

        [AllowAnonymous]
        public IActionResult Login(string previousUrl)
        {
            ViewBag.previousUrl = previousUrl;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginModel data)
        {
            var user = await _userManager.FindByEmailAsync(data.Email);

            if (user != null)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(user, data.Password, true, false);

                if (signInResult.Succeeded)
                {
                    return Json(new { isSuccess = true });
                }
            }

            return Json(new { isSuccess = false, message = "Invalid email or password!" });
        }

        [AllowAnonymous]
        public IActionResult Create()
        {
            return View("Signup");
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SignupModel data)
        {
            var isUserRole = await _roleManager.RoleExistsAsync("User");

            if (!isUserRole)
            {
                await _roleManager.CreateAsync(new IdentityRole("User"));
            }

            var newUser = new User
            {
                Email = data.Email,
                UserName = data.Username,
                Credit = 10000
            };

            var result = await _userManager.CreateAsync(newUser, data.Password);
            await _userManager.AddToRoleAsync(newUser, "User");

            if (result.Succeeded)
            {
                await _signInManager.PasswordSignInAsync(newUser, data.Password, true, false);
                return Json(new { success = true, message = "" });
            }
            else
            {
                var errorMessage = "";
                result.Errors.ToList().ForEach(e => errorMessage += e.Description + "\n");
                return Json(new { message = errorMessage });
            }
        }

        [AllowAnonymous]
        public IActionResult Recovery()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Recovery([FromBody]EmailModel data)
        {
            var user = await _userManager.FindByEmailAsync(data.Email);

            if (user != null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                var siteUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}{HttpContext.Request.PathBase}";

                _emailService.SendRecoveryEmail(user, HttpUtility.UrlEncode(token), siteUrl);

                return Json(new { isSuccess = true });
            }

            return Json(new { isSuccess = false, message = "Invalid email!" });
        }

        [AllowAnonymous]
        public IActionResult Reset(string token, string email)
        {
            ViewBag.Token = token;
            ViewBag.Email = email;

            return View();
        }
        
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Reset(string token, string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user != null)
            {
                var result = await _userManager.ResetPasswordAsync(user, token, password);

                if (result.Succeeded)
                {
                    await _signInManager.PasswordSignInAsync(user, password, true, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Token = token;
                    ViewBag.Email = email;

                    var errorMessage = "";
                    result.Errors.ToList().ForEach(e => errorMessage += e.Description + "\n");
                    ViewBag.Error = errorMessage;

                    return View();
                }
            }

            ViewBag.Error = "Email does not exist";

            return View();
        }

        public async Task<IActionResult> Signout()
        {
            if (User.Identity.IsAuthenticated) {
                await _signInManager.SignOutAsync();
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Tickets()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var ticketList = _ticketRepository.GetTicketListByUser(userId).OrderByDescending(t => t.Id);

            return View("UserTickets", ticketList);
        }

        public IActionResult Ticket(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var selectedTicket = _ticketRepository.GetTicketById(id);

            return View(selectedTicket);
        }

        public async Task<IActionResult> Settings()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            ViewBag.Credit = user.Credit;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangeUsername([FromBody]UsernameChangeModel data)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            user.UserName = data.Username;

            await _userManager.UpdateAsync(user);

            return Json(new { isSuccess = true });
        }

        [HttpPost]
        public async Task<IActionResult> ChangeEmail([FromBody]EmailModel data)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            bool isSuccess;
            var email = data.Email;

            if (email != null && email.Length > 0)
            {
                user.Email = email;
                isSuccess = true;
            }
            else
            {
                isSuccess = false;
            }

            await _userManager.UpdateAsync(user);

            return Json(new { isSuccess });
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword([FromBody]PasswordChangeModel data)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            var result = await _userManager.ChangePasswordAsync(user, data.OldPassword, data.NewPassword);

            await _userManager.UpdateAsync(user);

            return Json(new { isSuccess = result.Succeeded });
        }

        [HttpPost]
        public async Task<IActionResult> Deposit([FromBody] DepositModel data)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            user.Deposit(data.Amount);

            await _userManager.UpdateAsync(user);

            return Json(new { isSuccess = true });
        }
    }
}