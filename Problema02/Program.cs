using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de tarifa de envío");
        Console.Write("Ingresa el peso del paquete en kilogramos (puedes usar coma o punto): ");
        double peso = double.Parse((Console.ReadLine() ?? string.Empty).Replace(',', '.'), CultureInfo.InvariantCulture);
        int tarifa;
        if (peso <= 0)
        {
            tarifa = 0;
            Console.WriteLine("Peso inválido");
        }
        else if (peso < 1)
            tarifa = 8000;
        else if (peso < 5)
            tarifa = 15000;
        else if (peso < 20)
            tarifa = 32000;
        else
            tarifa = 60000;

        Console.WriteLine($"Tarifa: ${tarifa.ToString("N0", CultureInfo.GetCultureInfo("es-CO"))}");
    }
}
