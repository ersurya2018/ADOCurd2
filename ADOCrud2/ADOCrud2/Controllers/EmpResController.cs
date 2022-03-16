using ADOCrud2.DB_Connect;
using ADOCrud2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADOCrud2.Controllers
{
    public class EmpResController : Controller
    {
        // GET: EmpRes

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(EmpModel empObj)
        {
            MytableEntities objdb = new MytableEntities();

            myInfo tbl = new myInfo();

            tbl.Name = empObj.Name;
            tbl.Email = empObj.Email;
            tbl.Salary = empObj.Salary;
            tbl.City = empObj.City;
            tbl.Dept = empObj.Dept;

            objdb.myInfoes.Add(tbl);

            objdb.SaveChanges();

            return View();
        }

    }
}