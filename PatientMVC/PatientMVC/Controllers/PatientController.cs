using Microsoft.AspNetCore.Mvc;
using PatientMVC.DBHelper;
using PatientMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientMVC.Controllers
{
    public class PatientController : Controller
    {
        [HttpGet]
        public IActionResult List()
        {
            List<Patient> patients = PatientHelper.GetList();
            return View(patients);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            PatientHelper.Create(patient);
            return RedirectToAction("List");
        }
    }
}
