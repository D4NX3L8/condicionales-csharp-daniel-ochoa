using System;

class Program
{
    static void Main()
    {
        int opcion = int.Parse(Console.ReadLine() ?? string.Empty);
        string accion = opcion switch
        {
            1 => "Consultar saldo",
            2 => "Retirar",
            3 => "Depositar",
            4 => "Salir",
            _ => string.Empty
        };

        Console.WriteLine(accion.Length == 0 ? "Opción no válida" : $"Ha seleccionado: {accion}");
    }
}
