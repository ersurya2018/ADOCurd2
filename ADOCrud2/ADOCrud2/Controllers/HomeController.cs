using ADOCrud2.DB_Connect;
using ADOCrud2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADOCrud2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MytableEntities obj = new MytableEntities();

            var res = obj.myInfoes.ToList();

            List<EmpModel> empObj = new List<EmpModel>();

            foreach (var item in res)
            {
                empObj.Add(new EmpModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    Salary = item.Salary,
                    City = item.City,
                    Dept = item.Dept,
                }
                   );
            }


            return View(empObj);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}