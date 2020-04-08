﻿using iNeedTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iNeedTickets.Repos
{
    public class EFEventRepository : IEventRepository
    {
        private ApplicationDbContext dbContext;

        public EFEventRepository(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IQueryable<Event> GetAllUpcomingEvents() {
            return dbContext.Events
                .Where(e => e.Date >= DateTime.Now)
                .Include(e => e.TicketAreas)
                .Include(e => e.Location);
        }

        public Event GetEventById(int id) {
            return dbContext.Events
                .Where(e => e.Date >= DateTime.Now)
                .Include(e => e.TicketAreas)
                .Include(e => e.Location)
                .FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<Event> GetEventsByQuery(string query) {
            return dbContext.Events
                .Where(e => e.Date >= DateTime.Now)
                .Include(e => e.TicketAreas)
                .Include(e => e.Location)
                .Where(e => e.Name.Contains(query) || e.Location.Name.Contains(query))
                .OrderBy(e => e.Date);
        }

        public IQueryable<Event> GetEventsByType(EventCategory eventType, int selectionSize = 8)
        {
            return dbContext.Events
                .Where(e => e.Date >= DateTime.Now)
                .Include(e => e.TicketAreas)
                .Include(e => e.Location)
                .Where(e => e.EventType == eventType);
        }

        public IQueryable<Event> GetClosestUpcomingEvents(int selectionSize)
        {
            return dbContext.Events
                .Where(e => e.Date >= DateTime.Now)
                .Include(e => e.TicketAreas)
                .Include(e => e.Location)
                .OrderBy(e => e.Date)
                .Take(selectionSize);
        }
    }
}