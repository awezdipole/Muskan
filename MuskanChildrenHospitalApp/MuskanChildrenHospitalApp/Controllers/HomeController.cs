using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MuskanChildrenHospitalApp.Data;
using MuskanChildrenHospitalApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MuskanChildrenHospitalApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var query = (from p in context.Patients
                              join c in context.Addmisions on p.id equals c.PatientId
                              join r in context.Rooms on c.RoomId equals r.Id
                              join cu in context.Beds on c.BedId equals cu.id

                              select new MuskanChildrenHospitalApp.Models.Addmision
                              {
                                  id = c.id,
                                  RegistrationNumber = c.RegNo,
                                  RoomName = r.RoomName,
                                  BedName = cu.BedName,
                                  PatientName = p.Name,
                                  DateOfAdmission = c.DateOfAddmission,
                                  DateOfDischarge = c.DateOfDischarge,
                                  IsDischarge = c.IsDischarge
                              });
            return View(query);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
