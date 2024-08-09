using Microsoft.AspNetCore.Mvc;
using Programa.Models;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;
using System.Collections.Generic;

namespace Programa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Constructor que inyecta el servicio de logger
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Acción que maneja las solicitudes para la página de inicio
        public IActionResult Index()
        {
            return View();
        }

        // Acción que maneja las solicitudes para la página de privacidad
        public IActionResult Privacy()
        {
            // Ruta del archivo JSON
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "registro.json");

            // Lista para almacenar todos los datos de pacientes
            List<Paciente> allData = new List<Paciente>();

            // Verifica si el archivo JSON existe
            if (System.IO.File.Exists(filePath))
            {
                // Lee el contenido del archivo JSON
                var jsonData = System.IO.File.ReadAllText(filePath);
                try
                {
                    // Deserializa el JSON a una lista de objetos Paciente
                    allData = JsonSerializer.Deserialize<List<Paciente>>(jsonData) ?? new List<Paciente>();
                }
                catch (JsonException)
                {
                    // Manejo de errores si el JSON no está en el formato esperado
                    allData = new List<Paciente>();
                }
            }

            // Pasar los datos a la vista
            return View(allData);

        }

        [HttpPost]
        public IActionResult GuardarDatos(Paciente paciente)
        {
            // Ruta donde se guardará el archivo JSON
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "registro.json");

            // Crea un nuevo objeto Paciente con los datos del formulario
            var newData = new Paciente
            {
                nombre = paciente.nombre,
                cedula = paciente.cedula,
                fechaNacimiento = paciente.fechaNacimiento,
                edad = paciente.edad,
                direccion = paciente.direccion
            };

            // Leer datos existentes del archivo, si existe
            List<Paciente> allData = new List<Paciente>();

            var jsonData = System.IO.File.ReadAllText(filePath);
            try
            {
                allData = JsonSerializer.Deserialize<List<Paciente>>(jsonData) ?? new List<Paciente>();
            }
            catch (JsonException)
            {
                // Manejo de errores si el JSON no está en el formato esperado
                allData = new List<Paciente>();
            }

            allData.Add(newData);

            // Serializar el objeto a JSON
            var jsonString = JsonSerializer.Serialize(allData, new JsonSerializerOptions { WriteIndented = true });

            // Guardar el JSON en el archivo
            System.IO.File.WriteAllText(filePath, jsonString);

            // Redirige al usuario a una página de confirmación, o volver a mostrar la vista Privacy con los datos
            return RedirectToAction("Index");

        }

        // Acción que maneja las solicitudes para la página de error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
