using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bang_thong_tin.Models;

namespace bang_thong_tin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var nv = new NhanVien();
            ViewData["nv"] = nv;
            return View();
        }
	}
}