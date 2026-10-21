using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Evaluación de solicitud de crédito");
        Console.Write("¿El solicitante tiene empleo? Escribe true o false: ");
        bool tieneEmpleo = bool.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Ingresa el ingreso mensual en pesos, sin separadores: ");
        decimal ingreso = decimal.Parse((Console.ReadLine() ?? string.Empty).Replace(',', '.'), CultureInfo.InvariantCulture);
        string decision;
        if (!tieneEmpleo)
            decision = "Crédito rechazado";
        else if (ingreso >= 2500000)
            decision = "Crédito alto aprobado";
        else
            decision = "Crédito básico aprobado";

        Console.WriteLine(decision);
    }
}
