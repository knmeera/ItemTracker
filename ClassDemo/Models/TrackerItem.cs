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
        public string ItemSummary { set; get; }


        // Reference to other types
        public ItemCategory ItemCategory { set; get; }
        public ItemType ItemType { set; get; }


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