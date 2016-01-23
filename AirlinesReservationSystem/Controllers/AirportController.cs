using AirlinesReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirlinesReservationSystem.Controllers
{
    public class AirportController : Controller
    {
        private IApplicationDbContext db;

        public AirportController()
        {
            db = new ApplicationDbContext();
        }

        public AirportController(IApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        // GET: Airport
        public ActionResult Add()
        {
            return View();
        }

        // GET: Airport
        [HttpPost]
        public ActionResult Add(Airport airport)
        {
            if (ModelState.IsValid)
            {
                db.Airports.Add(airport);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


    }
}