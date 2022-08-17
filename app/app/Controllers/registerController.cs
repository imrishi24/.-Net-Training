using app.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app.Models;

namespace app.Controllers
{
    public class registerController : Controller
    {
        // GET: register
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            register mobj = new register();
            ViewBag.Message = "Thank you for scheduling appointment with us. We will call you before 30 mins of your appointment";
            return View();
        }
        public ActionResult enter()
        {
            return View(new register());
        }


        public ActionResult Schedule(register mobj)
        {
            if (ModelState.IsValid)
            {
                logindal calobj = new logindal();
               calobj.p2.Add(mobj);
                calobj.SaveChanges();
                return View("Display");
            }
            return View("enter", mobj);
        }
    }
}