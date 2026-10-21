using System;

class Program
{
    static void Main()
    {
        string jugador1 = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
        string jugador2 = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
        string resultado;

        if (jugador1 == jugador2 && EsJugadaValida(jugador1))
            resultado = "Empate";
        else if ((jugador1 == "piedra" && jugador2 == "tijera") ||
                 (jugador1 == "tijera" && jugador2 == "papel") ||
                 (jugador1 == "papel" && jugador2 == "piedra"))
            resultado = "Gana el jugador 1";
        else if (EsJugadaValida(jugador1) && EsJugadaValida(jugador2))
            resultado = "Gana el jugador 2";
        else
            resultado = "Jugada no válida";

        Console.WriteLine(resultado);
    }

    static bool EsJugadaValida(string jugada) => jugada is "piedra" or "papel" or "tijera";
}
