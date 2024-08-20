using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppVilla.Models;

namespace WebAppVilla.Controllers
{
    public class HomeController : Controller
    {
        villaEntities1 db = new villaEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public PartialViewResult pv_BestDeal()
        {
            return PartialView();
        }

        public PartialViewResult pv_Properties()
        {
            return PartialView();
        }

        public PartialViewResult pv_BD_Appartment()
        {
            var home = (from d in db.Properties select d).Take(1).ToList();
            return PartialView(home);
        }

        public PartialViewResult pv_BD_VillaHouse()
        {
            var home = (from d in db.Properties where d.Category == "Villa" select d).Take(1).ToList();
            return PartialView(home);
        }

        public PartialViewResult pv_BD_PentHouse()
        {
            var home = (from d in db.Properties where d.Category == "Penthouse" select d).Take(1).ToList();
            return PartialView(home);
        }

        public PartialViewResult pv_Contact()
        {
            return PartialView();
        }

    }
}