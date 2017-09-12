using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDemo.Models
{
    public class ItemPriority
    {
        public int PriorityId { set; get; }
        public string PriorityName { set; get; }

        public List<ItemPriority> GetItemPriority()
        {
            List<ItemPriority> lstPrt = new List<ItemPriority>();
            {
                lstPrt.Add(new ItemPriority { PriorityId = 1, PriorityName = "Urgent" });
                lstPrt.Add(new ItemPriority { PriorityId = 2, PriorityName = "High" });
                lstPrt.Add(new ItemPriority { PriorityId = 3, PriorityName = "Medium" });
                lstPrt.Add(new ItemPriority { PriorityId = 3, PriorityName = "Low" });
                return lstPrt;
            }
        }
    }
}