using Mvc_demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_demo1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private DataContext _context;

        public UserController()
        {
            _context = new DataContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ToList()
        {
            var list = _context.users.ToList();
            return View(list);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User users)
        {
            _context.users.Add(users);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}