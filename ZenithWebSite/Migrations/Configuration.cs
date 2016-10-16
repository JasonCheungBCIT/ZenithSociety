namespace ZenithWebSite.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<ZenithDataLib.Models.ZenithContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(ZenithDataLib.Models.ZenithContext context)
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
                FromDate = new DateTime(2016, 10, 5, 19, 0, 0),
                ToDate = new DateTime(2016, 10, 5, 20, 0, 0),
                CreatedBy = "Amanda",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 4, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 1)
            });
            events.Add(new Event()
            {
                EventId = 2,
                FromDate = new DateTime(2016, 10, 6, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 6, 12, 0, 0),
                CreatedBy = "Bob",
                IsActive = false,
                CreationDate = new DateTime(2016, 10, 5, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 2)
            });
            events.Add(new Event()
            {
                EventId = 3,
                FromDate = new DateTime(2016, 10, 7, 10, 30, 0),
                ToDate = new DateTime(2016, 10, 7, 12, 0, 0),
                CreatedBy = "Coot",
                IsActive = true,
                CreationDate = new DateTime(2016, 10, 6, 12, 0, 0),
                Activity = db.Activity.First(a => a.ActivityId == 3)
            });
            return events;
        }
    }
}
