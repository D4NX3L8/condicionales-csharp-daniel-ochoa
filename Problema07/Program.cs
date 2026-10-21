using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Clasificador del signo de un número");
        Console.Write("Ingresa un número entero: ");
        int numero = int.Parse(Console.ReadLine() ?? string.Empty);
        string signo = numero > 0 ? "Positivo" : numero < 0 ? "Negativo" : "Cero";
        Console.WriteLine(signo);
    }
}
