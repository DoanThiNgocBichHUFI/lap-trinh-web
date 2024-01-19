// lt web tuan 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using tuan2_bai3.Models;

namespace tuan2_bai3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var empl = new Employee();
            ViewData["empl"] = empl;
           
            return View();
        }

        public ActionResult Index1()
        {
            var nv = new NhanVien();
            return View(nv);
        }
}
}
