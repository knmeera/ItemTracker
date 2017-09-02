using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassDemo.Models;

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
            ItemCategory itmCatg = new ItemCategory();
            ItemType itmTy = new ItemType();

            ViewBag.CategoryId = new SelectList(itmCatg.GetItemCategories(), "CategoryId", "CategoryName");
            ViewBag.ItemTypeId = new SelectList(itmTy.GetItemTypes(), "ItemTypeId", "ItemName");

            return View();
        }
        [HttpPost]
        public ActionResult RazorForm(FormCollection frm)
        {
            var CategoryId = frm["CategoryId"];
            var ItemTypeId = frm["ItemTypeId"];
            var Priority = frm["Priority"];
            var Summary = frm["Summary"];


            TrackerItem ti = new TrackerItem();
            ti.ItemSummary = Summary;
           
            ti.Add(ti);


            ViewBag.Message = "Item has created successfully.";

            ItemCategory itmCatg = new ItemCategory();
            ItemType itmTy = new ItemType();

            ViewBag.CategoryId = new SelectList(itmCatg.GetItemCategories(), "CategoryId", "CategoryName");
            ViewBag.ItemTypeId = new SelectList(itmTy.GetItemTypes(), "ItemTypeId", "ItemName");

            return View();
        }


   

       

    }
 
}