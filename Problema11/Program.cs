using System;

enum EstadoSemaforo
{
    Rojo,
    Amarillo,
    Verde
}

class Program
{
    static void Main()
    {
        string entrada = Console.ReadLine() ?? string.Empty;
        if (!Enum.TryParse(entrada, true, out EstadoSemaforo estado) || !Enum.IsDefined(estado))
        {
            Console.WriteLine("Estado no válido");
            return;
        }

        string instruccion = estado switch
        {
            EstadoSemaforo.Rojo => "Deténgase",
            EstadoSemaforo.Amarillo => "Precaución, prepárese para detenerse",
            EstadoSemaforo.Verde => "Avance",
            _ => "Estado no válido"
        };
        Console.WriteLine(instruccion);
    }
}
