using GraduationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GraduationProject.Controllers
{
    public class HomeController : Controller
    {
        GraduationProjectDBEntities ctx = new GraduationProjectDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
        public ActionResult AddDoctor(Doctor dr)
        {
            
            ctx.Doctors.Add(dr);
            ctx.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult DonatingMedicine()
        {

            return View();
        }

        [HttpPost]
        public ActionResult DonatingMedicine(Medicine mdc)
        {
            if (ModelState.IsValid) { 
            ctx.Medicines.Add(mdc);
            ctx.SaveChanges();
                return View("DonatingMedicine");
            }
                else {
            return View(mdc);

                }

            return View();
            
        }
    }
}