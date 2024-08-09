using Microsoft.AspNetCore.Mvc;
using Programa.Models;
using System.Diagnostics;
using System.Reflection;

namespace Programa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            Paciente obj = new Paciente();
            obj.nombre = Request.Form["nombre"].ToString();
            obj.cedula = Request.Form["cedula"].ToString();
            obj.fechaNacimiento = DateTime.Parse(Request.Form["fecha_N"]);
            obj.edad = int.Parse(Request.Form["edad"]);
            obj.direccion = Request.Form["direccion"].ToString();

            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
