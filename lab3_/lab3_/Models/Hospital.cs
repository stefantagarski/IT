using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab3_.Models
{
    public class Hospital
    {
        [Key]
        public int ID { get; set; }

        [Display(Name= "HospitalName")]
        public string Name { get; set; }

        public string Image { get; set; }

        [Display(Name = "HospitalAddress")]

        public string Address { get; set; }

        public virtual List<Doctor> Doctors { get; set; }
    }
}