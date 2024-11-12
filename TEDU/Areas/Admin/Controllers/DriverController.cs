using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEDU.Areas.Admin.Models;

namespace TEDU.Areas.Admin.Controllers
{
    public class DriverController : Controller
    {
        // GET: Admin/Driver
        public ActionResult Index()
        {
            ViewBag.PageType = "Driver";
            ViewBag.Data = new List<Driver>
            {
                new Driver { EmployeeId = 01, FullName = "Thân Quốc Thịnh" , DateOfBirth = new DateTime(2004,7,28), Email = "thinhskyduck@gmail.com", PhoneNumber = "0364123957" , Role = "Tài xế", AssignedRoutes = new RouteInfo{ Departure = "Sài Gòn", Destionation = "Cần Thơ" } },
                new Driver { EmployeeId = 01, FullName = "Thân Quốc Thịnh" , DateOfBirth = new DateTime(2004,7,28), Email = "thinhskyduck@gmail.com", PhoneNumber = "0364123957" , Role = "Tài xế", AssignedRoutes = new RouteInfo{ Departure = "Sài Gòn", Destionation = "Cần Thơ" } },
                new Driver { EmployeeId = 01, FullName = "Thân Quốc Thịnh" , DateOfBirth = new DateTime(2004,7,28), Email = "thinhskyduck@gmail.com", PhoneNumber = "0364123957" , Role = "Tài xế", AssignedRoutes = new RouteInfo{ Departure = "Sài Gòn", Destionation = "Cần Thơ" } },
                new Driver { EmployeeId = 01, FullName = "Thân Quốc Thịnh" , DateOfBirth = new DateTime(2004,7,28), Email = "thinhskyduck@gmail.com", PhoneNumber = "0364123957" , Role = "Tài xế", AssignedRoutes = new RouteInfo{ Departure = "Sài Gòn", Destionation = "Cần Thơ" } },

            };
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
}