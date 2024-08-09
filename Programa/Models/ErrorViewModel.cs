namespace Programa.Models
{
    // Modelo que representa los detalles de un error en la aplicación
    public class ErrorViewModel
    {
        // Identificador único de la solicitud que causó el error
        // Puede ser nulo si no se proporciona un identificador
        public string? RequestId { get; set; }

        // Propiedad calculada que indica si se debe mostrar el RequestId
        // Se muestra si RequestId no es nulo o vacío
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}