using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassDemo.Models
{
    public class ProjectType
    {
        [Key]
        public int ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; }
        public string Enable { get; set; }

    }
}