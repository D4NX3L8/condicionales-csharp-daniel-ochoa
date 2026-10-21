using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double estatura = double.Parse((Console.ReadLine() ?? string.Empty).Replace(',', '.'), CultureInfo.InvariantCulture);
        int edad = int.Parse(Console.ReadLine() ?? string.Empty);
        bool acompanado = bool.Parse(Console.ReadLine() ?? string.Empty);
        bool puedeSubir = estatura >= 1.40 && (edad >= 12 || acompanado);
        Console.WriteLine(puedeSubir ? "Puede subir" : "No puede subir");
    }
}
