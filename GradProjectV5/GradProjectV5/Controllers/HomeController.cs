using GradProjectV5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GradProjectV5.Controllers
{
  public class HomeController : Controller
    {
        MyProjectDBEntities ctx = new MyProjectDBEntities();
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
      [HttpGet]
        public ActionResult DontatingMedicine()
        {

            return View();
        }
      [HttpPost]
      public ActionResult DontatingMedicine(Medicine mdc)
      {
          if (ModelState.IsValid)
          {
              ctx.Medicines.Add(mdc);
              ctx.SaveChanges();
              return View("DontatingMedicine");
          }
          else
          {
              return View(mdc);
          }

          return View("DontatingMedicine");

      }
        //public ActionResult AddDoctor(Doctor dr)
        //{
           
        //    ctx.Doctors.Add(dr);
        //    ctx.SaveChanges();
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult DonatingMedicine()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult DonatingMedicine(Medicine mdc)
        //{
        //    if (ModelState.IsValid) { 
        //    ctx.Medicines.Add(mdc);
        //    ctx.SaveChanges();
        //        return View("DonatingMedicine");
        //    }
        //        else {
        //    return View(mdc);

        //        }

        //    return View();
            
        
    }
}