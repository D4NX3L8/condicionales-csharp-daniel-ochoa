using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el número del día (1 = lunes, ..., 7 = domingo): ");
        int dia = int.Parse(Console.ReadLine() ?? string.Empty);
        string resultado = dia switch
        {
            >= 1 and <= 5 => "Día hábil",
            6 or 7 => "Fin de semana",
            _ => "Día inválido"
        };

        Console.WriteLine(resultado);
    }
}
