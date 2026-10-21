using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ubicación de un dron en el plano cartesiano");
        Console.Write("Ingresa la coordenada X: ");
        int x = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Ingresa la coordenada Y: ");
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
