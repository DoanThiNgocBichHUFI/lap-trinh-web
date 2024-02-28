using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShopHoa.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult SanPham()
        {
            return View();
        }

        public ActionResult DangKi()
        {
            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }

        public ActionResult LienHe()
        {
            return View();
        }
	}
}