﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iNeedTickets.Models
{
    public class EFEventRepository : IEventRepository
    {
        private ApplicationDbContext dbContext;

        public EFEventRepository(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IQueryable<Event> Events => dbContext.Events.Include(e => e.TicketTypes);
    }
}
