using System.ComponentModel.DataAnnotations;

namespace Programa.Models
{
    // Modelo que representa un paciente con información personal
    public class Paciente
    {
        // Nombre completo del paciente
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string nombre { get; set; }

        // Número de cédula del paciente
        [Required(ErrorMessage = "La cédula es obligatoria.")]
        public string cedula { get; set; }

        // Fecha de nacimiento del paciente
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateTime fechaNacimiento { get; set; }

        // Edad del paciente
        [Required(ErrorMessage = "La edad es obligatoria.")]
        public int edad { get; set; }

        // Dirección del paciente
        [Required(ErrorMessage = "La dirección es obligatoria.")]
        public string direccion { get; set; }
    }
}
