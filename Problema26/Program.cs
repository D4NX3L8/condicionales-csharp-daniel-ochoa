using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa la categoría del vehículo (M, A, B o C): ");
        char categoria = char.ToUpperInvariant(char.Parse(Console.ReadLine() ?? string.Empty));
        decimal tarifa = categoria switch
        {
            'M' => 0m,
            'A' => 12000m,
            'B' => 25000m,
            'C' => 38000m,
            _ => throw new InvalidOperationException("Categoría desconocida")
        };

        string tarifaFormateada = tarifa.ToString("N0", CultureInfo.GetCultureInfo("es-CO"));
        Console.WriteLine($"Categoría {categoria} - Tarifa: ${tarifaFormateada}");
    }
}
