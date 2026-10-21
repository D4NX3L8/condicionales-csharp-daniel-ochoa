using System;

class Program
{
    static void Main()
    {
        string entrada = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
        if (entrada.Length != 1 || !char.IsLetter(entrada[0]))
        {
            Console.WriteLine("No es una letra");
            return;
        }

        char letra = entrada[0];
        Console.WriteLine("aeiouáéíóú".Contains(letra) ? "Es vocal" : "Es consonante");
    }
}
