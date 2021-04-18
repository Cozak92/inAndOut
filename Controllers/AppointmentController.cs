using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Details(string name)
        {
            return Ok($"You have enterd name: { name}");

        }
    }
}
