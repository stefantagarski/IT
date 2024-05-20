using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab3_.Models
{
    public class Patient
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [Required]
        [RegularExpression("^\\d{5}$", ErrorMessage = "The code must be 5 digits")]
        [Display(Name = "Код на пациентот")]
        public int PatientCode { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

        public Patient()
        {
            Doctors = new List<Doctor>();
        }
    }
}