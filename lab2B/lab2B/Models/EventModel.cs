using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2B.Models
{
    public class EventModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The location name must be between 5 and 30 characters", MinimumLength = 5)]
        public string Location { get; set; }
    }
}