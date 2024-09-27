using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaccinationApp.Models
{
    public class VaccinePatients
    {
        public int vaccinCenterID { get; set; }

        public int patientID { get; set; }
        public int vaccineID { get; set; }

        public VaccinationCenter VaccinationCenter { get; set; }
        public DateTime DateTaken { get; set; }
        public List<Patient> Patients { get; set; }                                          

        public List<Vaccine> Vaccines { get; set; }

        public VaccinePatients() { 
        
            Patients = new List<Patient>(); 
            Vaccines = new List<Vaccine>();
        }
    }
}