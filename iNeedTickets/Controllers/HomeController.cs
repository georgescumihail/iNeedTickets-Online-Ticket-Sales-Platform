﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using iNeedTickets.Models;
using iNeedTickets.Repos;
using System.Security.Claims;
using iNeedTickets.Services;
using iNeedTickets.ML;

namespace iNeedTickets.Controllers
{
    public class HomeController : Controller
    {
        private IEventRepository _eventsRepository;
        private ITagRecommendationService _tagRecommendationService;
        private IMachineLearningRecommendationService _mlService;
        private const int ROW_SIZE = 4;

        public HomeController(IEventRepository eventsRepository, 
            ITagRecommendationService tagRecommendationService, 
            IMachineLearningRecommendationService mlService)
        {
            _eventsRepository = eventsRepository;
            _tagRecommendationService = tagRecommendationService;
            _mlService = mlService;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var lastEventId = _eventsRepository.GetLastEventByUser(userId);
            var availableEventIds = _eventsRepository.GetAllUpcomingEvents().Select(e => e.Id);

            var recommendedEvents = _tagRecommendationService.GetRecommendedEvents(userId, ROW_SIZE).ToList();

            var mlPrediction = _mlService.CreatePrediction(lastEventId, availableEventIds, ROW_SIZE);

            foreach(var p in mlPrediction)
            {
                recommendedEvents.Add(_eventsRepository.GetEventById(p.EventId));
            }

            return View(new MainPageModel
            {
                UpcomingEvents = _eventsRepository.GetClosestUpcomingEvents(ROW_SIZE * 2).ToList(),
                ConcertEvents = _eventsRepository.GetEventsByType(EventCategory.Concerts).ToList(),
                TheatreEvents = _eventsRepository.GetEventsByType(EventCategory.Theatre).ToList(),
                RecommendedEvents = recommendedEvents
            });
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
