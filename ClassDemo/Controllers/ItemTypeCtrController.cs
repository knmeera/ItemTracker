using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassDemo.Controllers
{
    public class ItemTypeCtrController : Controller
    {
        // GET: ItemType
        public ActionResult ItemType()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ItemType(FormCollection frm)
        {
            return View();
        }
    }
}