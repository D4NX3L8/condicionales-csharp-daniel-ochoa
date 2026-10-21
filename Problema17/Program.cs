using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Control del reproductor de música");
        Console.Write("Ingresa un comando (play, pause, stop o next): ");
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
