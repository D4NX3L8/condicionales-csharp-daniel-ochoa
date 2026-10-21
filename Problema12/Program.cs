using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        bool tieneEmpleo = bool.Parse(Console.ReadLine() ?? string.Empty);
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
