namespace Programa.Models
{
    // Modelo que representa un paciente con información personal
    public class Paciente
    {
        // Nombre completo del paciente
        public string nombre { get; set; }

        // Número de cédula del paciente
        public string cedula { get; set; }

        // Fecha de nacimiento del paciente
        public DateTime fechaNacimiento { get; set; }

        // Edad del paciente
        public int edad { get; set; }

        // Dirección del paciente
        public string direccion { get; set; }
    }
}
