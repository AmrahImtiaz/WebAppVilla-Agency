﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppVilla.Controllers
{
    public class PropertyController : Controller
    {
        
        // GET: Property
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Properties()
        {
            return View();
        }

        public ActionResult PropertyDetails()
        {
            return View();
        }

    }
}