using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDemo.Models
{
    public class ItemCategory
    {
        public int CategoryId { set; get; }
        public string CategoryName { set; get; }


        // Helper Methods
        public List<ItemCategory> GetItemCategories()
        {
            List<ItemCategory> lstcat = new List<ItemCategory>();
            lstcat.Add(new ItemCategory { CategoryId = 1, CategoryName = "Analysis" });
            lstcat.Add(new ItemCategory { CategoryId = 2, CategoryName = "Development" });
            lstcat.Add(new ItemCategory { CategoryId = 3, CategoryName = "Testing" });
            return lstcat;
        }
    }
}