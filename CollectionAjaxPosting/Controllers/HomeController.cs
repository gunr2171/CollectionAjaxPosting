using CollectionAjaxPosting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollectionAjaxPosting.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new Race();

            //start with one already filled in
            model.HorsesInRace.Add(new Horse() { Name = "Scooby", Age = 10 });

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Race postedModel)
        {
            if (ModelState.IsValid)
            {
                //model is valid, redirect to another page
                return RedirectToAction("ViewHorseListing");
            }
            else
            {
                //model is not valid, show the page again with validation errors
                return View(postedModel);
            }
        }

        [HttpGet]
        public ActionResult AjaxMakeHorseEntry()
        {
            //model is a blank horse
            var model = new List<Horse>() { new Horse() };
            return PartialView(model);
        }

    }
}