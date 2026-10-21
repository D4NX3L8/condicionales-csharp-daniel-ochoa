using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Comparador de dos números");
        Console.Write("Ingresa el primer número entero: ");
        int primero = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Ingresa el segundo número entero: ");
        int segundo = int.Parse(Console.ReadLine() ?? string.Empty);
        int mayor = primero > segundo ? primero : segundo;
        Console.WriteLine($"El mayor es {mayor}");
    }
}
