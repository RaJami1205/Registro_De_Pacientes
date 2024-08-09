namespace Programa.Models
{
    public class Paciente
    {
        public String nombre { get; set; }
        public String cedula { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edad { get; set; }
        public String direccion { get; set; }

        // Constructores
        public Paciente()
        {
        }

        public Paciente(String nombre, String cedula, DateTime fechaNacimiento, int edad, String direccion)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
            this.direccion = direccion;
        }
    }
}
