using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDemo.Models
{
    public class ItemType
    {
        public int ItemTypeId { set; get; }
        public string ItemName { set; get; }

        public List<ItemType> GetItemTypes()
        {
            List<ItemType> lstty = new List<ItemType>();
            lstty.Add(new ItemType { ItemTypeId = 1, ItemName = "Backlog" });
            lstty.Add(new ItemType { ItemTypeId = 2, ItemName = "Action" });
            lstty.Add(new ItemType { ItemTypeId = 3, ItemName = "Issue" });
            lstty.Add(new ItemType { ItemTypeId = 4, ItemName = "Task" });
            return lstty;
        }

    }
}