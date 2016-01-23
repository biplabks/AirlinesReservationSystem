using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AirlinesReservationSystem.Models;

namespace AirlinesReservationSystem.Controllers
{
    public class BookingAgentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BookingAgents
        public ActionResult Index()
        {
            return View(db.BookingAgents.ToList());
        }

        // GET: BookingAgents/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingAgent bookingAgent = db.BookingAgents.Find(id);
            if (bookingAgent == null)
            {
                return HttpNotFound();
            }
            return View(bookingAgent);
        }

        // GET: BookingAgents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingAgents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "agent_id,agent_name,agent_details")] BookingAgent bookingAgent)
        {
            if (ModelState.IsValid)
            {
                db.BookingAgents.Add(bookingAgent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookingAgent);
        }

        // GET: BookingAgents/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingAgent bookingAgent = db.BookingAgents.Find(id);
            if (bookingAgent == null)
            {
                return HttpNotFound();
            }
            return View(bookingAgent);
        }

        // POST: BookingAgents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "agent_id,agent_name,agent_details")] BookingAgent bookingAgent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookingAgent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookingAgent);
        }

        // GET: BookingAgents/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingAgent bookingAgent = db.BookingAgents.Find(id);
            if (bookingAgent == null)
            {
                return HttpNotFound();
            }
            return View(bookingAgent);
        }

        // POST: BookingAgents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BookingAgent bookingAgent = db.BookingAgents.Find(id);
            db.BookingAgents.Remove(bookingAgent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
