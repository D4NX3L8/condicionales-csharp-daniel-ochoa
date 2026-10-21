using System;

class Program
{
    static void Main()
    {
        int velocidad = int.Parse(Console.ReadLine() ?? string.Empty);
        string sancion = velocidad < 0 ? "Lectura inválida" :
            velocidad <= 50 ? "Sin infracción" :
            velocidad <= 70 ? "Multa leve" :
            velocidad <= 90 ? "Multa grave" : "Multa gravísima e inmovilización";
        Console.WriteLine(sancion);
    }
}
