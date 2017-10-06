using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassDemo.Controllers
{
    public class ItemCategoryCtrController : Controller
    {
        // GET: ItemCategory
        public ActionResult ItemCategory()
        {
            return View();
        }
    [HttpPost]
        public ActionResult ItemCategory(FormCollection frm)
        {
            return View();
        }
    }
}