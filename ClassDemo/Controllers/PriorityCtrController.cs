using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassDemo.Controllers
{
    public class PriorityCtrController : Controller
    {
        // GET: Priority
        public ActionResult Priority()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Priority(FormCollection frm)
        {
            return View();
        }
    }
}