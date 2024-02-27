using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai5.Controllers
{
    public class NhapController : Controller
    {
        //
        // GET: /Nhap/
        [HttpGet]
        public ActionResult Nhap()
        {
            return View();
        }

	}
}