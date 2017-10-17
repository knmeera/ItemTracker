using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClassDemo.Models
{
    public class ProjectPricingModel
    {
        [Key]
        public int ProjectPricingModelId { get; set; }
        public string ProjectPricingModelName { get; set; }
        public string Enable { get; set; }
    }
}