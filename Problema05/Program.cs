using System;

class Program
{
    static void Main()
    {
        int primero = int.Parse(Console.ReadLine() ?? string.Empty);
        int segundo = int.Parse(Console.ReadLine() ?? string.Empty);
        int mayor = Math.Max(primero, segundo);
        Console.WriteLine($"El mayor es {mayor}");
    }
}
