using System;

class Program
{
    static void Main()
    {
        int nivel = int.Parse(Console.ReadLine() ?? string.Empty);
        if (nivel < 15)
            Console.WriteLine("Batería baja: conecte el cargador");

        Console.WriteLine($"Nivel actual: {nivel} %");
    }
}
