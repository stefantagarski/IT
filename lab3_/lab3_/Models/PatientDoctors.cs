using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3_.Models
{
    public class PatientDoctors
    {
        public int patientID { get; set; }
        public int doctorID { get; set; }

        public Doctor Doctor { get; set; }

        public ICollection<Patient> Patients { get; set; }

        public PatientDoctors()
        {
            Patients = new List<Patient>();
        }
    }
}