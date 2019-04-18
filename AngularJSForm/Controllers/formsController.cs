using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJSForm.Controllers
{
    public class formsController : Controller
    {
        // GET: forms
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult forms(string id)
        {
            ViewBag.FormName = id;
            return View();
        }
    }
}