using PatientMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientMVC.DBHelper
{
    public class PatientHelper
    {
        internal static List<Patient> GetList()
        {
            HospitalDbContext db = new HospitalDbContext();
            List<Patient> patients = db.Patients.ToList();
            return patients;
        }
        internal static void Create(Patient patient)
        {
            HospitalDbContext db = new HospitalDbContext();
            db.Patients.Add(patient);
            db.SaveChanges();
        }

    }
}
