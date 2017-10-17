using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Web;
using ClassDemo.Models;
using ClassDemo.Context;
using System.ComponentModel.DataAnnotations.Schema;


namespace ClassDemo.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        public string ProjectCode { get; set; }
        public string ContantName { get; set; }
        public string ContantEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string PricingModelId { get; set; }
        public string PricingModelName { get; set; }

        public string AssignedTo { get; set; }
        public string IsInternalProject { get; set; }
        public string Platform { get; set; }
        public string Domain { get; set; }
        public string Technology { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string CustomerContantName { get; set; }
        public string CustomerEmail { get; set; }
        public string ReqResources { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Enable { get; set; }
        public string Disable { get; set; }

        //forien keys
        public int ClientId { get; set; }
        public int ProjectTypeId { get; set; }
        public int ProjectPricingModelId { get; set; }
        public virtual ICollection<TrackerItem> TrackerItems { get; set; }

        //relation one-to-many (one)
        public virtual Client Client{ get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public virtual ProjectPricingModel ProjectPricingModel { set; get; }
        
    }
}