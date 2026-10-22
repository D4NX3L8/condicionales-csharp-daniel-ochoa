using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el rol (admin, instructor o aprendiz): ");
        string rol = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
        Console.Write("Ingresa la hora de llegada (0 a 23): ");
        int hora = int.Parse(Console.ReadLine() ?? string.Empty);

        bool horaValida = hora is >= 0 and <= 23;
        bool accesoPermitido = horaValida && rol switch
        {
            "admin" => true,
            "instructor" => hora is >= 6 and <= 21,
            "aprendiz" => hora is >= 6 and <= 18,
            _ => false
        };

        Console.WriteLine(accesoPermitido ? "Acceso permitido" : "Acceso denegado");
    }
}
