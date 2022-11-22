using Microsoft.AspNetCore.Mvc;
using PatientMVC.DBHelper;
using PatientMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientMVC.Controllers
{
    public class AppointmentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Patient patient=new Patient();
            Patient patientA=new Patient();
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            List<Appiontment> appiontments = AppointmentHelper.GetList();
            return View(appiontments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Symptoms = new List<string> { "Cough", "Sneez", "Pain" };
            return View();
        }
        [HttpPost]
        public IActionResult Create(Appiontment appiontment)
        {
            AppointmentHelper.Create(appiontment);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Appiontment appiontment = AppointmentHelper.GetById(id);
            return View(appiontment);
        }
    }
}
