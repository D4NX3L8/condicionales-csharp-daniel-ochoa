using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Estado final del aprendiz");
        Console.Write("Ingresa la nota final entre 0 y 5 (puedes usar coma o punto): ");
        decimal nota = decimal.Parse((Console.ReadLine() ?? string.Empty).Replace(',', '.'), CultureInfo.InvariantCulture);
        string estado = nota >= 3.0m ? "Aprobado" : "Reprobado";
        Console.WriteLine($"Nota: {nota.ToString("0.0", CultureInfo.GetCultureInfo("es-CO"))} - {estado}");
    }
}
