using System;

class Program
{
    static void Main()
    {
        int primero = int.Parse(Console.ReadLine() ?? string.Empty);
        int segundo = int.Parse(Console.ReadLine() ?? string.Empty);
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
