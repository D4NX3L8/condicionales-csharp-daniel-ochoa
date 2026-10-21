using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Analizador de datos recibidos");
        Console.Write("Ingresa un texto, un número entero, un decimal o un booleano (true/false): ");
        string entrada = Console.ReadLine() ?? string.Empty;
        object dato;
        if (bool.TryParse(entrada, out bool booleano))
            dato = booleano;
        else if (int.TryParse(entrada, NumberStyles.Integer, CultureInfo.InvariantCulture, out int entero))
            dato = entero;
        else if (double.TryParse(entrada.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double decimalDato))
            dato = decimalDato;
        else
            dato = entrada;

        string descripcion = dato switch
        {
            string texto => $"Texto de {texto.Length} caracteres",
            int valor => $"Entero: {valor}",
            double valor => $"Decimal: {valor.ToString(CultureInfo.InvariantCulture)}",
            bool valor => $"Booleano: {valor}",
            _ => "Tipo no reconocido"
        };
        Console.WriteLine(descripcion);
    }
}
