using System;

class Program
{
    static void Main()
    {
        Console.Write("Usuario: ");
        string usuario = Console.ReadLine() ?? string.Empty;

        if (usuario != "aprendiz")
        {
            Console.WriteLine("Usuario no encontrado");
            return;
        }

        Console.Write("Contraseña: ");
        string contrasena = Console.ReadLine() ?? string.Empty;
        if (contrasena == "Sena2026")
        {
            Console.WriteLine("Bienvenido");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta");
        }
    }
}
