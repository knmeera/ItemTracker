using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassDemo.Controllers
{
    public class StatusCtrController : Controller
    {
        // GET: Status
        public ActionResult Status()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Status(FormCollection frm)
        {
            return View();
        }


    }
}