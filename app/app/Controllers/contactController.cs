using app.DAL;
using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace app.Controllers
{
    public class contactController : Controller
    {
        // GET: contact
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult show()
        {
            contact mobj = new contact();
            ViewBag.Message = "Thank you for contact us. We will get in touch ASAP";
            return View();
        }
        public ActionResult input()
        {
            return View(new contact());
        }

        public ActionResult submit(contact mobj)
        {
            if (ModelState.IsValid)
            {
                logindal calobj = new logindal();
                calobj.p3.Add(mobj);
                calobj.SaveChanges();
                return View("show");
            }
            return View("input", mobj);
        }
    }
}