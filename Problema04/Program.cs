using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Alerta de batería");
        Console.Write("Ingresa el nivel actual de batería (porcentaje de 0 a 100): ");
        int nivel = int.Parse(Console.ReadLine() ?? string.Empty);
        if (nivel < 15)
            Console.WriteLine("Batería baja: conecte el cargador");

        Console.WriteLine($"Nivel actual: {nivel} %");
    }
}
