using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ban_hoa.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        public ActionResult DangKy()
        {
            return View();
        }
        public ActionResult LienHe()
        {
            return View();
        }
	}
}