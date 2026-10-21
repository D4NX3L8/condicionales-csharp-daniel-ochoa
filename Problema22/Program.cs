using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora básica");
        Console.Write("Ingresa el primer número entero: ");
        int primero = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Ingresa el segundo número entero: ");
        int segundo = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Ingresa el operador (+, -, * o /): ");
        char operador = char.Parse(Console.ReadLine() ?? string.Empty);
        double resultado = operador switch
        {
            '+' => primero + segundo,
            '-' => primero - segundo,
            '*' => primero * segundo,
            '/' when segundo == 0 => throw new InvalidOperationException("No se puede dividir entre cero"),
            '/' => (double)primero / segundo,
            _ => throw new InvalidOperationException("Operador no soportado")
        };
        Console.WriteLine($"{primero} {operador} {segundo} = {resultado}");
    }
}
