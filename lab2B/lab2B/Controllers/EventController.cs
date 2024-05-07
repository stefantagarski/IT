using lab2B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2B.Controllers
{
    public class EventController : Controller
    {
        private static List<EventModel> events = new List<EventModel>() 
        {
            new EventModel() {ID = 1, Name = "Coachella", Location = "California"},
            new EventModel() {ID = 2, Name = "TomorrowLand", Location = "Bloom"},
            new EventModel() {ID = 3, Name = "Sziget", Location = "Budapest"}
        };

        public ActionResult ShowAllEvents()
        {
            return View(events);
        }

        public ActionResult AddEvent() {
            EventModel model = new EventModel();

            return View(model);
        }

        public ActionResult ShowInformations()
        {
            EventModel model = new EventModel();

            return View(model);
        }


        [HttpPost]
        public ActionResult CreateNewEvent(EventModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("AddEvent", model);
            }else
            {
                events.Add(model);
                return View("ShowInformations", model);
            }
        }

        public ActionResult DeleteEvent(int id)
        {
            events.RemoveAt(id);
            return View("ShowAllEvents", events);
        }

        public ActionResult EditEvent(int id)
        {
           var model = events.ElementAt(id);
            return View("EditEvent", model);
        }

        [HttpPost]
        public ActionResult EditEvent(EventModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("EditEvent", model);
            }
            else
            {
                var forUpdate = events.ElementAt(model.ID);
                forUpdate.Name = model.Name;
                forUpdate.Location = model.Location;

                return View("ShowAllEvents", events);
            }
        }

    }
}
