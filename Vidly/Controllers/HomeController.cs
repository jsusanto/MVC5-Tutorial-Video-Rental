﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //To enable cache on particular view/controller
        [OutputCache(Duration = 50, Location = OutputCacheLocation.Server, VaryByParam = "genre")] 
        public ActionResult Index()
        {
            return View();
        }      

        //To disable caching
        [OutputCache(Duration = 0, VaryByParam = "*", NoStore = true)]
        public ActionResult About()
        {
            throw new Exception();

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}