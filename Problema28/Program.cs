using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");
        Console.Write("Ingresa el valor de la compra: ");
        decimal compra = decimal.Parse(Console.ReadLine() ?? string.Empty, CultureInfo.InvariantCulture);
        if (compra < 0)
        {
            throw new InvalidOperationException("El valor de la compra no puede ser negativo");
        }

        Console.Write("¿El cliente es frecuente? (sí/no): ");
        string respuestaFrecuente = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
        bool clienteFrecuente = respuestaFrecuente switch
        {
            "sí" or "si" => true,
            "no" => false,
            _ => throw new InvalidOperationException("Respuesta de cliente frecuente desconocida")
        };

        decimal porcentajeDescuento = compra switch
        {
            >= 500000m => 15m,
            >= 200000m => 10m,
            >= 100000m => 5m,
            _ => 0m
        };
        if (clienteFrecuente && compra >= 100000m)
        {
            porcentajeDescuento += 5m;
        }

        decimal total = compra * (1m - porcentajeDescuento / 100m);
        string compraFormateada = compra.ToString("N0", cultura);
        string totalFormateado = total.ToString("N0", cultura);
        Console.WriteLine($"Compra: ${compraFormateada}");
        Console.WriteLine($"Descuento total: {porcentajeDescuento:0}%");
        Console.WriteLine($"Total a pagar: ${totalFormateado}");
    }
}
