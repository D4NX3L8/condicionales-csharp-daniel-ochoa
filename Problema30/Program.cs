using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa la primera nota (0 a 100): ");
        decimal nota1 = LeerNota();
        Console.Write("Ingresa la segunda nota (0 a 100): ");
        decimal nota2 = LeerNota();
        Console.Write("Ingresa la tercera nota (0 a 100): ");
        decimal nota3 = LeerNota();

        decimal promedio = (nota1 + nota2 + nota3) / 3m;
        char letra = promedio switch
        {
            >= 90m => 'A',
            >= 80m => 'B',
            >= 70m => 'C',
            >= 60m => 'D',
            _ => 'F'
        };
        string retroalimentacion = letra switch
        {
            'A' => "Desempeño excelente",
            'B' or 'C' => "Buen desempeño, sigue así",
            'D' => "Aprobado, refuerza los temas",
            _ => "Debe presentar plan de mejoramiento"
        };
        string estado = promedio >= 60m ? "Aprobado" : "Reprobado";
        string promedioFormateado = promedio.ToString("F1", CultureInfo.GetCultureInfo("es-CO"));

        Console.WriteLine($"Promedio: {promedioFormateado} | Letra: {letra} | {retroalimentacion} | {estado}");
        if (promedio == 100m)
        {
            Console.WriteLine("¡Mención de honor!");
        }
    }

    static decimal LeerNota()
    {
        decimal nota = decimal.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
        if (nota is < 0m or > 100m)
        {
            throw new InvalidOperationException("La nota debe estar entre 0 y 100");
        }

        return nota;
    }
}
