using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Form1()
        {
            return View(); 
        }



        [HttpPost]
        public ActionResult Form1(FormCollection frm)
        {
            var id = frm["id"];
            var surename = frm["surname"];
            var name = frm["name"];
            var gender = frm["gender"];
            var age = frm["age"];
            var mobile = frm["mobile"];
            
            
            var Salutation = (gender == "Male" ? "Mr" : "Miss");
            //ViewData["Message"] = "Welcome " + name;
            ViewBag.Message= "Thank you " +Salutation +"."+ name +" " + surename +" for your form submission. We will revert you soon.";

            return View();
        }
        public ActionResult RazorForm()
        {
            ViewBag.CategoryId = new SelectList(GetItemCategories(), "CategoryId", "CategoryName");
            ViewBag.ItemTypeId = new SelectList(GetItemTypes(), "ItemTypeId", "ItemName");

            return View();
        }
        [HttpPost]
        public ActionResult RazorForm(FormCollection frm)
        {
            var CategoryId = frm["CategoryId"];
            var ItemTypeId = frm["ItemTypeId"];
            var Priority = frm["Priority"];


            ViewBag.Message = "Item has created successfully.";

            ViewBag.CategoryId = new SelectList(GetItemCategories(), "CategoryId", "CategoryName");
            ViewBag.ItemTypeId = new SelectList(GetItemTypes(), "ItemTypeId", "ItemName");

            return View();
        }


       // Helper Methods
        private List<ItemCategoty> GetItemCategories()
        {
            List<ItemCategoty> lstcat = new List<ItemCategoty>();
            lstcat.Add(new ItemCategoty { CategoryId = 1, CategoryName = "Analysis" });
            lstcat.Add(new ItemCategoty { CategoryId = 2, CategoryName = "Development" });
            lstcat.Add(new ItemCategoty { CategoryId = 3, CategoryName = "Testing" });
            return lstcat;
        }

        private List<ItemType> GetItemTypes()
        {
            List<ItemType> lstty = new List<ItemType>();
            lstty.Add(new ItemType { ItemTypeId = 1, ItemName = "Backlog" });
            lstty.Add(new ItemType { ItemTypeId = 2, ItemName = "Action" });
            lstty.Add(new ItemType { ItemTypeId = 3, ItemName = "Issue" });
            return lstty;
        }


    }


    // Objects
    public class ItemCategoty
    {
        public int CategoryId { set; get; }
        public string CategoryName { set; get; }
    }

    public class ItemType
    {
        public int ItemTypeId { set; get; }
        public string ItemName { set; get; }

    }


}