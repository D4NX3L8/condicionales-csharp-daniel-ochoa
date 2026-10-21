using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Verificación de acceso a la montaña rusa");
        Console.Write("Ingresa tu estatura en metros (por ejemplo, 1,45): ");
        double estatura = double.Parse((Console.ReadLine() ?? string.Empty).Replace(',', '.'), CultureInfo.InvariantCulture);
        Console.Write("Ingresa tu edad en años: ");
        int edad = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("¿Vas acompañado por un adulto? Escribe true o false: ");
        bool acompanado = bool.Parse(Console.ReadLine() ?? string.Empty);
        bool puedeSubir = estatura >= 1.40 && (edad >= 12 || acompanado);
        Console.WriteLine(puedeSubir ? "Puede subir" : "No puede subir");
    }
}
