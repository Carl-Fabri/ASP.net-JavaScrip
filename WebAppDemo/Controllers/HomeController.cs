using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;


namespace WebAppDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<ServiciosModel> servicios = new List<ServiciosModel>()
        {
            new ServiciosModel
            {
                Nombre = "Transporte a Apurimac",
                Cantidad = 12
            },
            new ServiciosModel
            {
                Nombre = "Transporte a Chile",
                Cantidad = 52
            },
            new ServiciosModel
            {
                Nombre = "Transporte a Argentina",
                Cantidad = 32
            }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            //ServiciosModel serv1 = new ServiciosModel();
            //serv1.Nombre = "Transporte a Apurimac";
            //serv1.Cantidad = 12;
            //servicios.Add(serv1);

            //ServiciosModel serv2 = new ServiciosModel();
            //serv2.Nombre = "Transporte a Chile";
            //serv2.Cantidad = 52;
            //servicios.Add(serv2);

            //ServiciosModel serv3 = new ServiciosModel();
            //serv3.Nombre = "Transporte a Argentina";
            //serv3.Cantidad = 32;
            //servicios.Add(serv3);
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            var empresa = new EmpresaModel
            {
                Codigo = 1,
                RazonSocial = "Empresa de Transportes S.A.C.",
                Descripcion = "Somos una empresa de transporte interprovincial"
            };

            return View(empresa);
        }

        public IActionResult Cliente()
        {
            return View(servicios);
        }


        [HttpPost]
        public IActionResult Cliente(IFormCollection formCollection,string submitbtn, string npom12, string can12, int transporte)
        {

            string _nombre;
            
            ServiciosModel serv3 = new ServiciosModel();
            switch (submitbtn)
            {
                case "limpiar":
             
                    return View(servicios);

                case "guardar":
                    if (formCollection["nom1"] != "")
                    {
                        servicios.Add(new ServiciosModel { Nombre = formCollection["nom1"], Cantidad = Convert.ToInt32(formCollection["can1"]) });
                        
                    }
                    return View(servicios);

                case "eliminar":
                    
                    servicios.RemoveAt(transporte);
                    return View(servicios);

                case "actualizar":
                    if (transporte > -1)
                    {

                        servicios[transporte] = (new ServiciosModel { Nombre = formCollection["nom1"], Cantidad = Convert.ToInt32(formCollection["can1"]) });
                    }

                    return View(servicios);


                default:
                    return View(servicios);
            }
         
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
