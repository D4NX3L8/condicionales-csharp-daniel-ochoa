using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Resumen del carrito de compras");
        Console.Write("¿Cuántos artículos hay en el carrito?: ");
        int cantidad = int.Parse(Console.ReadLine() ?? string.Empty);
        string mensaje = $"Tienes {cantidad} {(cantidad == 1 ? "artículo" : "artículos")} en el carrito";
        Console.WriteLine(mensaje);
    }
}
