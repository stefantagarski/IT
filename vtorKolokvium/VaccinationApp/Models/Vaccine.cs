using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VaccinationApp.Models
{
    public class Vaccine
    {
        [Key]
        public int Id { get; set; }
        public string Manufacturer { get; set;}
        public Guid Certificate { get; set; }
        public DateTime DateTaken { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual VaccinationCenter VaccinationCenter { get; set; }

        public Vaccine() {
            Guid guid = Guid.NewGuid();
            Certificate = guid;
        }


    }
}