using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab3_.Models
{
    public class Doctor
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [Display(Name = "Hospital")]
        public int hospitalID { get; set; }
        public virtual Hospital Hospital { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

        public Doctor()
        {
            Patients = new List<Patient>();
        }
    }
}