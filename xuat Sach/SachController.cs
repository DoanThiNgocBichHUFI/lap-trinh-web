using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai5.Models;

namespace bai5.Controllers
{
    public class SachController : Controller
    {
        //
        // GET: /Sach/
        public ActionResult Index1()
        {
            return View();  
        }
        static List<Sach> bookList = new List<Sach>();
        public SachController()
        {
        }
        static int sl = 0;
        [HttpPost]
        public ActionResult Index(string txt_id, string txt_name, string txt_pri, string file_avatar)
        {
            //double price = double.Parse(txt_pri);
            //Sach b = new Sach(txt_id, txt_name, price, file_avatar);
            Sach b = new Sach(txt_id, txt_name, txt_pri, file_avatar);
            bookList.Add(b);
            sl++;
            if (sl < 3) return View();
            else
            {
                return RedirectToAction("OuputBookList", "Sach");
            }
        }
        [HttpGet]
        public ActionResult OuputBookList()
        {
            //ViewBag.bookList = new List<Sach>();
            //ViewBag.bookList = bookList;
            //return View();

            //var nv = new Sach();
            //ViewData["nv"] = nv;
            //return View();

            return View(bookList);

        }
	}
}