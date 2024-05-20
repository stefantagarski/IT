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

        public string HospitalName { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

        public Doctor()
        {
            Patients = new List<Patient>();
        }
    }
}