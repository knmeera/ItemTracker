using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDemo.Models
{

    public class TrackerItem
    {
        private static List<TrackerItem> _context = new List<TrackerItem>();

        public int ItemId { set; get; }
        public string ItemSummary { set; get; }
        public int ItemCategory { set; get; }
        public int ItemType { set; get; }
        public string ItemPriority { set; get; }
        public string ItemCreatedDate { set; get; }
        public string AssignedDate { set; get; }
        public string ItemEndDate { set; get; }
        public string WorkCompleted { set; get; }
        public int ItemStatus { set; get; }
        public string CreatedBy { set; get; }
        public string Owner { set; get; }
        public string Impact { set; get; }
        public string Resolution { set; get; }
        public string Resolved { set; get; }
        public string AttachmentPath { set; get; }


        public List<TrackerItem> GetTrackerItems()
        {
             return _context;
        }

        public void Add(TrackerItem itm)
        {
            _context.Add(itm);

        }

        public IEnumerable<TrackerItem> GetAll()
        {
            return _context.ToList();
        }


        public void Edit(TrackerItem itm)
        {

        }
        public void Delete(TrackerItem itm)
        {

        }



    }


}