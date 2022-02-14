using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult ListadoServicios()
        {

            return View();

        }
    }
}
