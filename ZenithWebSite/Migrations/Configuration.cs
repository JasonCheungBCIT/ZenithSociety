namespace ZenithWebSite.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(ZenithContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Activity.AddOrUpdate(a => a.ActivityId, getActivities().ToArray());
            context.SaveChanges();
            context.Event.AddOrUpdate(e => e.EventId, getEvents(context).ToArray());
            context.SaveChanges();
    
        }

        private List<Activity> getActivities()
        {
            List<Activity> activities = new List<Activity>();
            activities.Add(new Activity()
            {
                ActivityId = 1,
                ActivityDescription = "Young ladies cooking lessons",
                CreationDate = new DateTime(2015, 12, 30, 23, 59, 59)
            });
            activities.Add(new Activity()
            {
                ActivityId = 2,
                ActivityDescription = "Youth choir practice",
                CreationDate = new DateTime(2015, 12, 30, 23, 59, 59)
            });
            activities.Add(new Activity()
            {
                ActivityId = 3,
                ActivityDescription = "Bingo Tournament",
                CreationDate = new DateTime(2015, 12, 30, 23, 59, 59)
            });
            return activities;
        }

        private List<Event> getEvents(ZenithContext db)
        {
            List<Event> events = new List<Event>();
            events.Add(new Event()
            {
                EventId = 1,
                FromDate = new DateTime(2016, 11, 5, 19, 0, 0),
                ToDate = new DateTime(2016, 11, 5, 20, 0, 0),
                CreatedBy = "Amanda",
                IsActive = true,
                CreationDate = new DateTime(2016, 11, 4, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 1)
            });
            events.Add(new Event()
            {
                EventId = 2,
                FromDate = new DateTime(2016, 11, 6, 10, 30, 0),
                ToDate = new DateTime(2016, 11, 6, 12, 0, 0),
                CreatedBy = "Bob",
                IsActive = false,
                CreationDate = new DateTime(2016, 11, 5, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 2)
            });
            events.Add(new Event()
            {
                EventId = 3,
                FromDate = new DateTime(2016, 11, 7, 10, 30, 0),
                ToDate = new DateTime(2016, 11, 7, 12, 0, 0),
                CreatedBy = "Coot",
                IsActive = true,
                CreationDate = new DateTime(2016, 11, 6, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 3)
            });
            events.Add(new Event()
            {
                EventId = 4,
                FromDate = new DateTime(2016, 11, 7, 10, 30, 0),
                ToDate = new DateTime(2016, 11, 7, 12, 0, 0),
                CreatedBy = "Coot",
                IsActive = true,
                CreationDate = new DateTime(2016, 11, 6, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 1)
            });
            events.Add(new Event()
            {
                EventId = 5,
                FromDate = new DateTime(2016, 10, 28, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 28, 12, 0, 0),
                CreatedBy = "Bob",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 2)
            });
            events.Add(new Event()
            {
                EventId = 6,
                FromDate = new DateTime(2016, 10, 25, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 25, 12, 0, 0),
                CreatedBy = "Francis",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 1)
            });
            events.Add(new Event()
            {
                EventId = 7,
                FromDate = new DateTime(2016, 10, 26, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 26, 12, 0, 0),
                CreatedBy = "Francis",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 2)
            });
            events.Add(new Event()
            {
                EventId = 8,
                FromDate = new DateTime(2016, 10, 27, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 27, 12, 0, 0),
                CreatedBy = "Francis",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 3)
            });
            events.Add(new Event()
            {
                EventId = 9,
                FromDate = new DateTime(2016, 10, 27, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 27, 12, 0, 0),
                CreatedBy = "Francis",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 1)
            });
            events.Add(new Event()
            {
                EventId = 10,
                FromDate = new DateTime(2016, 10, 28, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 28, 12, 0, 0),
                CreatedBy = "Francis",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 1)
            });
            events.Add(new Event()
            {
                EventId = 11,
                FromDate = new DateTime(2016, 10, 29, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 29, 12, 0, 0),
                CreatedBy = "Francis",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 2)
            });
            events.Add(new Event()
            {
                EventId = 12,
                FromDate = new DateTime(2016, 10, 21, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 21, 12, 0, 0),
                CreatedBy = "Jay",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 2)
            });
            events.Add(new Event()
            {
                EventId = 13,
                FromDate = new DateTime(2016, 10, 21, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 21, 12, 0, 0),
                CreatedBy = "Bob",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 1)
            });
            events.Add(new Event()
            {
                EventId = 14,
                FromDate = new DateTime(2016, 10, 22, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 22, 12, 0, 0),
                CreatedBy = "Bob",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 2)
            });
            events.Add(new Event()
            {
                EventId = 15,
                FromDate = new DateTime(2016, 10, 23, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 23, 12, 0, 0),
                CreatedBy = "Bob",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 20, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 1)
            });



            return events;
        }
    }
}
