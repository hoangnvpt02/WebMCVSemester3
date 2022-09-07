using Assigment5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assigment5.Controllers
{
    public class UserController : Controller
    {

        private static List<UserModel> _users = new List<UserModel>();
        // GET: User
        public ActionResult Index()
        {
            return View(_users);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            UserModel user = _users.Find(emp => emp.Idd == id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                UserModel user = new UserModel();
                user.Idd = Int32.Parse(collection["Idd"]);
                user.ConfirmPassword = collection["ConfirmPassword"];
                user.Email = collection["email"];
                user.Password = collection["password"];
                user.Name = collection["name"];
                _users.Add(user);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}