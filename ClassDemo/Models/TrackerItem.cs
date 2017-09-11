using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDemo.Models
{

    public class TrackerItem
    {
        List<TrackerItem> lstItems = new List<TrackerItem>();

        public int ItemId { set; get; }
        public string ItemSummary  { set; get; }
        public int ItemCategory { set; get; }
        public int ItemType { set; get; }
        public string ItemPriority { set; get; }
        public DateTime ItemCreatedDate { set; get; }
        public DateTime? AssignedDate { set; get; }
        public DateTime? ItemEndDate { set; get; }
        public string WorkCompleted { set; get; }
        public int ItemStatus { set; get; }
        public string CreatedBy { set; get; }
        public string  Owner { set; get; }
        public string Impact { set; get; }
        public string Resolution { set; get; }
        public string Resolved { set; get; }



        public List<TrackerItem> GetTrackerItems()
        {
             return lstItems;
        }

        public void Add(TrackerItem itm)
        {
            lstItems.Add(itm);

        }

        public void Edit(TrackerItem itm)
        {

        }
        public void Delete(TrackerItem itm)
        {

        }



    }


}