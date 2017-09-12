using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDemo.Models
{
    public class ItemStatus
    {
       
        public int ItemStatusId { set; get; }
        public string ItemStatusName { set; get; }

        public List<ItemStatus> GetItemStatus()
        {
            List<ItemStatus> lstSts = new List<ItemStatus>();
            lstSts.Add(new ItemStatus { ItemStatusId = 1, ItemStatusName = "Open" });
            lstSts.Add(new ItemStatus { ItemStatusId = 2, ItemStatusName = "Assigned" });
            lstSts.Add(new ItemStatus { ItemStatusId = 3, ItemStatusName = "Resolved" });
            lstSts.Add(new ItemStatus { ItemStatusId = 4, ItemStatusName = "Cancel" });
            return lstSts;
        }
        
    }
}