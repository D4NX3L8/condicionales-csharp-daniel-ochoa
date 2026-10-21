using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double peso = LeerDecimal();
        double estatura = LeerDecimal();
        if (estatura <= 0)
        {
            Console.WriteLine("Estatura inválida");
            return;
        }

        double imc = peso / (estatura * estatura);
        string categoria = imc < 18.5 ? "Bajo peso" : imc < 25 ? "Peso normal" : imc < 30 ? "Sobrepeso" : "Obesidad";
        Console.WriteLine($"IMC: {imc.ToString("F1", CultureInfo.GetCultureInfo("es-CO"))} - {categoria}");
    }

    static double LeerDecimal() => double.Parse((Console.ReadLine() ?? string.Empty).Replace(',', '.'), CultureInfo.InvariantCulture);
}
