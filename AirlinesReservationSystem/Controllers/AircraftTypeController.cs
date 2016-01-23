using AirlinesReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirlinesReservationSystem.Controllers
{
    public class AircraftTypeController : Controller
    {
        private IApplicationDbContext db;

        public AircraftTypeController()
        {
            db = new ApplicationDbContext();
        }

        public AircraftTypeController(IApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        // GET: AircraftType
        public ActionResult Add()
        {
            return View();
        }

        // GET: AircraftType
        [HttpPost]
        public ActionResult Add(AircraftType aircraftType)
        {
            if(ModelState.IsValid)
            {
                db.AircraftTypes.Add(aircraftType);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}