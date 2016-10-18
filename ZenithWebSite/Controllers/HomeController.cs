using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZenithDataLib.Models;

namespace ZenithWebSite.Controllers
{
    public class HomeController : Controller
    {
        private ZenithContext db = new ZenithContext();
        public ActionResult Index()
        {
            var @event = db.Event.Include(that => that.Activity);

            Dictionary<String, List<Event>> Week = new Dictionary<String, List<Event>>();

            //Find the monday of this week
            DateTime today = DateTime.Now;
            int delta = DayOfWeek.Monday - today.DayOfWeek;
            if (delta > 0)
                delta -= 7;
            DateTime monday = today.AddDays(delta);
            ViewBag.monday = monday.ToLongDateString();
            DateTime sunday = monday.AddDays(7);

            //Allow only days this week
            @event = @event.Where(e => e.FromDate >= monday && e.FromDate < sunday);

            //add to dictionary
            foreach (var index in @event)
            {
                if (index.IsActive)
                {
                    if (Week.ContainsKey(index.FromDate.ToLongDateString()))
                    {

                        Week[index.FromDate.ToLongDateString()].Add(index);
                    }
                    else
                    {
                        Week[index.FromDate.ToLongDateString()] = new List<Event> { index };
                    }
                }
            }

            ViewBag.Week = Week.ToList();

            return View();
        }

        public ActionResult All()
        {
            var @event = db.Event.Include(that => that.Activity);

            Dictionary<String, List<Event>> Week = new Dictionary<String, List<Event>>();


            //add to dictionary
            foreach (var index in @event)
            {
                if (index.IsActive)
                {
                    if (Week.ContainsKey(index.FromDate.ToLongDateString()))
                    {
                        Week[index.FromDate.ToLongDateString()].Add(index);
                    }
                    else
                    {
                        Week[index.FromDate.ToLongDateString()] = new List<Event>();
                        Week[index.FromDate.ToLongDateString()].Add(index);
                    }
                }
            }

            ViewBag.Week = Week.ToList();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}