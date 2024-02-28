using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dieuHuong.Controllers
{
    public class KhoaController : Controller
    {
        //
        // GET: /Khoa/
        public ActionResult Index()
        {
            Models.KhoaModel khoaCntt = new Models.KhoaModel();
            //khoaCntt.Message = "Học tập- năng động- sáng tạo";
            return View(khoaCntt);
        }
	}
}