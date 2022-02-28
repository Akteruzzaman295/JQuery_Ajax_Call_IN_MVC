using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryAjaxCallINMVC.Controllers
{
    public class JQueryAjaxCallController : Controller
    {
        //
        // GET: /JQueryAjaxCall/
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult AjaxPostCall(Employee employeeData)
        {
            Employee employee = new Employee
            {
                Name = employeeData.Name,
                Designation = employeeData.Designation,
                Location = employeeData.Location
            };
            return Json(employee,JsonRequestBehavior.AllowGet);
        }

    }
    public class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Location { get; set; }
    }
}