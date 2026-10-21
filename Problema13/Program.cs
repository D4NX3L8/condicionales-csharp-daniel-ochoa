using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Consulta de país por código");
        Console.Write("Ingresa el código de dos letras (CO, MX, AR, PE o CL): ");
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
