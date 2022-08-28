using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            TempData["Name"] = "Nguyễn Văn Hoàng";
            TempData["Age"] = "20";
            TempData["Address"] = "Cầu Giấy, Hà Nội";
            TempData.Keep();
            return View("ShowData");
        }

        public ActionResult ShowData()
        {
            TempData.Keep();
            return View();
        }
    }
}