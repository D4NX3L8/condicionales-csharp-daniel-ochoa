using System;

class Program
{
    static void Main()
    {
        int numero = int.Parse(Console.ReadLine() ?? string.Empty);
        string signo = numero > 0 ? "Positivo" : numero < 0 ? "Negativo" : "Cero";
        Console.WriteLine(signo);
    }
}
