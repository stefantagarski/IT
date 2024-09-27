using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VaccinationApp.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Range(1000000000000,9999999999999,ErrorMessage ="The embg is not 13 digits")]
        public string Embg { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        [Display(Name ="Patient Phone")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual List<Vaccine> Vaccines { get; set; }

        public Patient() { 
            Vaccines = new List<Vaccine>();
        
        }
    }
}