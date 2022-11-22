using PatientMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientMVC.DBHelper
{
    public class AppointmentHelper
    {
        internal static List<Appiontment> GetList()
        {
            HospitalDbContext db = new HospitalDbContext();
            List<Appiontment> appiontments = db.Appiontments.ToList();
            return appiontments;
        }
        internal static Appiontment Create(Appiontment appiontment)
        {
            HospitalDbContext db = new HospitalDbContext();
            db.Appiontments.Add(appiontment);
            db.SaveChanges();
            return appiontment;
        }
        internal static Appiontment GetById(int id)
        {
            HospitalDbContext db = new HospitalDbContext();
            Appiontment result = db.Appiontments.Find(id);
            return result;


        }


    }
}
