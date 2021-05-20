using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult QuoteCalc(string FirstName, string LastName, string EmailAddress,
                                      DateTime DateOfBirth, int CarYear, string CarMake, string CarModel,
                                      int SpeedingTickets, bool CoverageType = false, bool DUI = false)
        {
                using (InsuranceEntities db = new InsuranceEntities())
                {

                    var insuree = new Insuree();
                    insuree.FirstName = FirstName;
                    insuree.LastName = LastName;
                    insuree.EmailAddress = EmailAddress;
                    insuree.DateOfBirth = DateOfBirth;
                    insuree.CarYear = CarYear;
                    insuree.CarMake = CarMake;
                    insuree.CarModel = CarModel;
                    insuree.DUI = DUI;
                    insuree.CoverageType = CoverageType;
                    insuree.SpeedingTickets = SpeedingTickets;
                    insuree.Quote = TotalQuote(insuree);

                    db.Insurees.Add(insuree);
                    db.SaveChanges();

                    return View(insuree);
                }
            }

            private decimal TotalQuote(Insuree quote)
            {

                decimal quoteTotal = 50m;


                int userBirth = Convert.ToDateTime(quote.DateOfBirth).Year;
                int yearNow = DateTime.Now.Year;
                int userAge = yearNow - userBirth;

                // checking age

                if (userAge <= 18)
                {
                    quoteTotal += 25;
                }
                else if (userAge >= 19 && userAge <= 25)
                {
                    quoteTotal += 50;
                }
                else if (userAge > 25)
                {
                    quoteTotal += 25;
                }
                // checking car year

                if (quote.CarYear < 2000 || quote.CarYear > 2015)
                {
                    quoteTotal += 25;

                }

                //checking car make and model
                if (quote.CarMake.ToLower() == "porsche")
                {
                    quoteTotal += 25;
                    if (quote.CarModel.ToLower() == "911 carrera") quoteTotal += 25;

                }

                //check for speeding tickets
                if (quote.SpeedingTickets > 0)
                {
                    quoteTotal = quoteTotal + (quote.SpeedingTickets * 10);

                }

                // check for DUI
                if (quote.DUI == true)
                {
                    quoteTotal += quoteTotal / 4;

                }
                // chek for coverage
                if (quote.CoverageType == true)
                {
                    quoteTotal += quoteTotal / 2;
                }

            decimal quoteTotal1 = Math.Round(quoteTotal, 2);
            return quoteTotal1;
            }

        }
    
    }

                
                

           

        
