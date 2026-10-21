using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine() ?? string.Empty);
        int y = int.Parse(Console.ReadLine() ?? string.Empty);
        string ubicacion = (x, y) switch
        {
            (0, 0) => "Origen",
            (0, _) or (_, 0) => "Sobre un eje",
            (> 0, > 0) => "Primer cuadrante",
            (< 0, > 0) => "Segundo cuadrante",
            (< 0, < 0) => "Tercer cuadrante",
            _ => "Cuarto cuadrante"
        };
        Console.WriteLine(ubicacion);
    }
}
