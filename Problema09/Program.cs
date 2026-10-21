using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Verificador de año bisiesto");
        Console.Write("Ingresa un año: ");
        int anio = int.Parse(Console.ReadLine() ?? string.Empty);
        bool esBisiesto = anio % 400 == 0 || (anio % 4 == 0 && anio % 100 != 0);
        Console.WriteLine(esBisiesto ? "Bisiesto" : "No bisiesto");
    }
}
