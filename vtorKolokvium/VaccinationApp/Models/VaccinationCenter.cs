using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VaccinationApp.Models
{
    public class VaccinationCenter
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MaxCapacity { get; set; }

        public virtual List<Vaccine> Vaccines { get; set; }
        public virtual List<Patient> Patients { get; set; }

        public VaccinationCenter() {
            Vaccines = new List<Vaccine>();
            Patients = new List<Patient>();
        }  
    }
}