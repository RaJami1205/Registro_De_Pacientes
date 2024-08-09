namespace Programa.Models
{
    // Modelo que representa los detalles de un error en la aplicaci�n
    public class ErrorViewModel
    {
        // Identificador �nico de la solicitud que caus� el error
        // Puede ser nulo si no se proporciona un identificador
        public string? RequestId { get; set; }

        // Propiedad calculada que indica si se debe mostrar el RequestId
        // Se muestra si RequestId no es nulo o vac�o
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}