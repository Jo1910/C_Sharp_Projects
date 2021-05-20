using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var insureeVms = new List<InsureeVm>();
                foreach (var insuree in insurees)
                {
                    var insureeVm = new InsureeVm();
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.Quote = Convert.ToInt32(insuree.Quote);

                    insureeVms.Add(insureeVm);
                }
                return View(insureeVms);
            }
        }

        // GET: Admin/Details/5
    //    public ActionResult Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Insuree insuree = db.Insurees.Find(id);
    //        if (insuree == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(insuree);
    //    }

    //    // GET: Admin/Create
    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Admin/Create
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Insurees.Add(insuree);
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }

    //        return View(insuree);
    //    }

    //    // GET: Admin/Edit/5
    //    public ActionResult Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Insuree insuree = db.Insurees.Find(id);
    //        if (insuree == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(insuree);
    //    }

    //    // POST: Admin/Edit/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Entry(insuree).State = EntityState.Modified;
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }
    //        return View(insuree);
    //    }

    //    // GET: Admin/Delete/5
    //    public ActionResult Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Insuree insuree = db.Insurees.Find(id);
    //        if (insuree == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        return View(insuree);
    //    }

    //    // POST: Admin/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteConfirmed(int id)
    //    {
    //        Insuree insuree = db.Insurees.Find(id);
    //        db.Insurees.Remove(insuree);
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }
    }
}
