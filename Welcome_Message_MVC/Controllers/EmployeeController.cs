using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Welcome_Message_MVC.Models;

namespace Welcome_Message_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Abc()
        {
            TBLEmployee TBLEmp = new TBLEmployee();
            TBLEmp.emp_name = "Birju";
            return View("Welcome",TBLEmp);
        }
    }
}