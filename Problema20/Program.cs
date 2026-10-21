using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Consulta de días del mes (año no bisiesto)");
        Console.Write("Ingresa el número del mes (1 = enero, ..., 12 = diciembre): ");
        int mes = int.Parse(Console.ReadLine() ?? string.Empty);
        string resultado = mes switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => "31 días",
            4 or 6 or 9 or 11 => "30 días",
            2 => "28 días",
            _ => "Mes inválido"
        };
        Console.WriteLine(resultado);
    }
}
