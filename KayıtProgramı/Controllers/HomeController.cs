using KayıtProgramı.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KayıtProgramı.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {

                Session["user"] = model;
                return RedirectToAction("Index");

            }
            return View(model);
        }
        public ActionResult logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
    