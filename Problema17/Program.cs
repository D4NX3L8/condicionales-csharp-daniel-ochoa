using System;

class Program
{
    static void Main()
    {
        string comando = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
        string mensaje = comando switch
        {
            "play" => "Reproduciendo...",
            "pause" => "En pausa",
            "stop" => "Detenido",
            "next" => "Siguiente canción",
            _ => "Comando no reconocido"
        };
        Console.WriteLine(mensaje);
    }
}
