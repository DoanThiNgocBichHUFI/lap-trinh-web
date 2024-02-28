using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using nhap_tt_Sach.Models;

namespace nhap_tt_Sach.Controllers
{
    public class SachController : Controller
    {
        //
        // GET: /Sach/

        public ActionResult Index1()
        {
            return View(DSSach.listSach);
        }
        
        public ActionResult Input()
        {
            return View();
        }


        public ActionResult Upload(HttpPostedFileBase AnhBia)
        {
            if (AnhBia != null && AnhBia.ContentLength > 0)
            {
                var newFileName = Guid.NewGuid();
                var _extension = Path.GetExtension(AnhBia.FileName);
                string NewName = newFileName + _extension;
                string _FileName = Path.GetFileName(NewName);
                string _path = Path.Combine(Server.MapPath("~/Images"), _FileName);
                AnhBia.SaveAs(_path);
            }
            return RedirectToAction("Index1");
        }

        public ActionResult OutputBookList(string maSach, string tenSach, double gia, string anhBia)
        {
            DSSach.listSach.Add(new Sach() { MaSach = maSach, TenSach = tenSach, Gia = gia, AnhBia = anhBia });
            return RedirectToAction("Index1");
        }
	}
}