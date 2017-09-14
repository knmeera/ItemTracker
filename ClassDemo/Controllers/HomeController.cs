using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassDemo.Models;
using System.IO;

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
            ViewBag.Message = "Thank you " + Salutation + "." + name + " " + surename + " for your form submission. We will revert you soon.";

            return View();
        }

        public ActionResult ItemsList()
        {
            TrackerItem ti = new TrackerItem();
            var itms = ti.GetAll();

            return View(itms);
        }

        public ActionResult ItemsLists()
        {
            TrackerItem ti = new TrackerItem();
            var itms = ti.GetAll();

            return View(itms);
        }
        public ActionResult RazorForm()
        {
            ItemCategory itmCatg = new ItemCategory();
            ItemType itmTy = new ItemType();
            ItemStatus itmSts = new ItemStatus();
            ItemPriority itmPry = new ItemPriority();

            ViewBag.CategoryVB = new SelectList(itmCatg.GetItemCategories(), "CategoryId", "CategoryName");
            ViewBag.ItemTypeVB = new SelectList(itmTy.GetItemTypes(), "ItemTypeId", "ItemName");
            ViewBag.ItemStatusVB = new SelectList(itmSts.GetItemStatus(), "ItemStatusId", "ItemStatusName");
            ViewBag.ItemPriorityVB = new SelectList(itmPry.GetItemPriority(), "PriorityId", "PriorityName");

            return View();
        }
        [HttpPost]
        public ActionResult RazorForm(TrackerItem itm, HttpPostedFileBase file)
        {
            //var ItemCategory = frm["ItemCategory"];
            // var CategoryId = frm["CategoryId"];
            //var ItemTypeId = frm["ItemType"];
            //var Priority = frm["Priority"];

            //var ItemCreatedDate = frm["ItemCreatedDate"];
            //var CreatedBy = frm["CreatedBy"];
            //var Owner = frm["Owner"];
            //var Imapct = frm["Imapct"];
            //var Resolution = frm["Resolution"];
            //var Resolved =frm["Resolved"];

            var fileName = String.Empty;
            if (ValidateForm(itm))
            {
                //File Validation
                if (file != null && file.ContentLength > 0)
                {
                    fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/upload_attachements"), fileName);
                    file.SaveAs(path);
                }

                // After data validation Success 
                TrackerItem ti = new TrackerItem();
                ti.ItemId = itm.ItemId;
                ti.ItemSummary = itm.ItemSummary;

                ti.ItemCategory = itm.ItemCategory;
                ti.ItemType = itm.ItemType;
                ti.ItemPriority = itm.ItemPriority;
                ti.ItemStatus = itm.ItemStatus;

                ti.ItemCreatedDate = itm.ItemCreatedDate;
                ti.ItemEndDate = itm.ItemEndDate;
                ti.AttachmentPath = fileName;


                ti.Add(ti);

                if (ModelState.IsValid)
                {
                    ViewBag.Message = "Item has created successfully.";
                    return RedirectToAction("ItemsList", "Home");
                }

                //ViewBag.Message = "Item has created successfully.";
                //RedirectToAction("ItemsList","Home");
            }
            else
            {
                //Error
                ViewBag.Message = "There are errors in creating Item.";
            }


            ItemCategory itmCatg = new ItemCategory();
            ItemType itmTy = new ItemType();
            ItemStatus itmSts = new ItemStatus();
            ItemPriority itmPry = new ItemPriority();

            ViewBag.CategoryVB = new SelectList(itmCatg.GetItemCategories(), "CategoryId", "CategoryName");
            ViewBag.ItemTypeVB = new SelectList(itmTy.GetItemTypes(), "ItemTypeId", "ItemName");
            ViewBag.ItemStatusVB = new SelectList(itmSts.GetItemStatus(), "ItemStatusId", "ItemStatusName");
            ViewBag.ItemPriorityVB = new SelectList(itmPry.GetItemPriority(), "PriorityId", "PriorityName");
            return View();
        }

        public ActionResult Edit(int ID)
        {
            // To be Loaded in Edit form
            ItemCategory itmCatg = new ItemCategory();
            ItemType itmTy = new ItemType();
            ItemStatus itmSts = new ItemStatus();
            ItemPriority itmPry = new ItemPriority();

            TrackerItem itmObj = new TrackerItem();
            var item = itmObj.GetById(ID);

            ViewBag.CategoryVB = new SelectList(itmCatg.GetItemCategories(), "CategoryId", "CategoryName", item.ItemCategory);
            ViewBag.ItemTypeVB = new SelectList(itmTy.GetItemTypes(), "ItemTypeId", "ItemName", item.ItemType);
            ViewBag.ItemStatusVB = new SelectList(itmSts.GetItemStatus(), "ItemStatusId", "ItemStatusName", item.ItemStatus);
            ViewBag.ItemPriorityVB = new SelectList(itmPry.GetItemPriority(), "PriorityId", "PriorityName", item.ItemPriority);


            return View(item);
        }
        [HttpPost]
        public ActionResult Edit(TrackerItem itm)
        {
            TrackerItem ti = new TrackerItem();
            ti.Update(itm);
            return RedirectToAction("ItemsList");
        }
        
        // this the validation method
        private bool ValidateForm(TrackerItem itm)
        {

            if (itm.ItemId == 0)
                ModelState.AddModelError("ItemId", "Please enter Item Id.");
            else if (itm.ItemSummary == null )
                ModelState.AddModelError("ItemSummary", "Please enter ItemSummary");
            else if (itm.ItemCategory==0)
                ModelState.AddModelError("ItemCategory", "Please enter ItemCategory");
            else if (itm.ItemType == 0)
                ModelState.AddModelError("ItemType", "Please enter ItemCategory");
            else if (itm.ItemPriority == "0")
                ModelState.AddModelError("Priority", "Please enter Priority");
            else if (itm.ItemCreatedDate== null)
                ModelState.AddModelError("ItemCreatedDate", "Please enter Date");
            else if (itm.CreatedBy == null)
                ModelState.AddModelError("CreatedBy", "Please enter CreatedBy");
            else if (itm.Owner== null)
                ModelState.AddModelError("Owner", "Please enter Owner");
            //else if (itm.Impact == null)
            //    ModelState.AddModelError("Impact", "Please enter Impact");
            //else if (itm.Resolution == null)
            //    ModelState.AddModelError("Resolution", "Please enter Resolution");
            else if (itm.ResolvedDate == null)
                ModelState.AddModelError("Resolved", "Please enter Resolved");
            return ModelState.IsValid;
        }
       
        
    }
 
}