using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MentorTasks.Web.MvcBasics.Models
{
    public class Customer
    {
        [Required]
        public string Name{ get; set; }
    }
}