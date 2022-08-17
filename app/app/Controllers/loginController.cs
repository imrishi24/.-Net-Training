using app.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app.Models;

namespace app.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult display()
        {
            login dobj = new login();
            return View(dobj);
        }
        public ActionResult Enter()
        {
            return View(new login());
        }


        public ActionResult submit(login dobj)
        {
            if (ModelState.IsValid)
            {
                logindal dalobj = new logindal();
                dalobj.p1.Add(dobj);
                dalobj.SaveChanges();
                return View("display", dobj);
            }
            return View("Enter", dobj);
        }

    }
}