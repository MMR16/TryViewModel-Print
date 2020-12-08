using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        readonly DBContext Db = new DBContext();
        // GET: Home
        public ActionResult Index()
        {
            var users = Db.Users.ToList();
            return View(users);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserViewModel LiteUser)
        {
            if (ModelState.IsValid)
            {
                var u = new User() { Age = LiteUser.Age, Name = LiteUser.Name, Degree = LiteUser.Degree };
                Db.Users.Add(u);
                 Db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(LiteUser);
        }
    }
}