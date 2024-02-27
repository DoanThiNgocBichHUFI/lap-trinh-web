using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai1.Models;

namespace bai1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        QL_NhanSuNEntities db = new QL_NhanSuNEntities();
        public ActionResult showDepartment()
        {
            return View(db.tbl_Deparment.ToList());
        }

        //public ActionResult showDepartment()
        //{
        //    List<tbl_Deparment> listDept = db.tbl_Deparment.ToList();
        //    return View(listDept);
        //}
        public ActionResult showEmployee()
        {
            return View(db.tbl_Employee.ToList());
        }
        public ActionResult createDept()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createDept(tbl_Deparment dept)
        {
            if (ModelState.IsValid)
            {
              
                    db.tbl_Deparment.Add(dept);
                    db.SaveChanges();
                    return RedirectToAction("showDepartment", "Home");
            }
            return View(dept);
        }

        public ActionResult updateDept(int id = 1)
        {
            tbl_Deparment dept = db.tbl_Deparment.Single(d => d.DeptId == id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            return View(dept);
        }

        [HttpPost]
        public ActionResult updateDept(tbl_Deparment dept)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Deparment.Attach(dept);// dinh kem doi tg thuc the voi db
                db.Entry(dept).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("showDepartment", "Home");
            }
            return View(dept);
        }


        public ActionResult detailDept(int id = 1)
        {
            int soNV = (int)(db.tbl_Employee.Include("tbl_Deparment").Where(d => d.DeptId == id).ToList().Count());
            tbl_Deparment dept = db.tbl_Deparment.ToList().Single(d => d.DeptId == id);
            if (dept == null)
            {
                return HttpNotFound();
            }
            
            return View(dept);
        }

        public ActionResult createEmployee()
        {
            ViewBag.DeptId = new SelectList(db.tbl_Deparment, "DeptId", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult createEmployee(tbl_Employee empl)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Employee.Add(empl);
                db.SaveChanges();
                return RedirectToAction("showEmployee", "Home");
            }
            return View(empl);
        }
	}
}