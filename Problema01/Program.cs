using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Registro electoral");
        Console.Write("¿Cuántos años tienes?: ");
        int edad = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine(edad >= 16 ? "Puede votar" : "Aún no puede votar");
    }
}
