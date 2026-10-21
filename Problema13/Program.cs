using System;

class Program
{
    static void Main()
    {
        string codigo = (Console.ReadLine() ?? string.Empty).Trim().ToUpperInvariant();
        string pais = codigo switch
        {
            "CO" => "Colombia",
            "MX" => "México",
            "AR" => "Argentina",
            "PE" => "Perú",
            "CL" => "Chile",
            _ => "País no registrado"
        };
        Console.WriteLine(pais);
    }
}
