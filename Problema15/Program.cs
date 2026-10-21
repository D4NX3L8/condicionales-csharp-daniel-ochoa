using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de índice de masa corporal");
        double peso = LeerDecimal("Ingresa tu peso en kilogramos: ");
        double estatura = LeerDecimal("Ingresa tu estatura en metros (por ejemplo, 1,75): ");
        if (estatura <= 0)
        {
            Console.WriteLine("Estatura inválida");
            return;
        }

        double imc = peso / (estatura * estatura);
        string categoria = imc < 18.5 ? "Bajo peso" : imc < 25 ? "Peso normal" : imc < 30 ? "Sobrepeso" : "Obesidad";
        Console.WriteLine($"IMC: {imc.ToString("F1", CultureInfo.GetCultureInfo("es-CO"))} - {categoria}");
    }

    static double LeerDecimal(string mensaje)
    {
        Console.Write(mensaje);
        return double.Parse((Console.ReadLine() ?? string.Empty).Replace(',', '.'), CultureInfo.InvariantCulture);
    }
}
