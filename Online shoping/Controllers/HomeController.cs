﻿using Online_shoping.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_shoping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string search,int? page)
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            return View(model.CreateModel(search,page));
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
    }
}