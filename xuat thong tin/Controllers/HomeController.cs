﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using xuatthongtin.Models;

namespace xuatthongtin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            var empl = new Employee();
            ViewData["empl"] = empl;
            return View();
        }
	}
}