using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el día de la semana: ");
        string dia = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
        Console.Write("¿La persona es estudiante? (sí/no): ");
        string respuestaEstudiante = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
        bool estudiante = respuestaEstudiante switch
        {
            "sí" or "si" => true,
            "no" => false,
            _ => throw new InvalidOperationException("Respuesta de estudiante desconocida")
        };

        decimal precio = dia switch
        {
            "martes" => 7000m,
            "sábado" or "sabado" or "domingo" => 15000m,
            "lunes" or "miércoles" or "miercoles" or "jueves" or "viernes" => estudiante ? 9000m : 12000m,
            _ => throw new InvalidOperationException("Día desconocido")
        };

        string precioFormateado = precio.ToString("N0", CultureInfo.GetCultureInfo("es-CO"));
        Console.WriteLine($"Precio de la boleta: ${precioFormateado}");
    }
}
