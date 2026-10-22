# Problema 28. Descuento por compra

**Estructura elegida:** expresión `switch` para el descuento base y condición `if` para el beneficio adicional.
**Justificación:** Los rangos de compra son excluyentes y se evalúan de mayor a menor. El 5 % del programa frecuente se suma únicamente cuando la compra es de al menos $100.000.

## Evidencia
La captura de este ejercicio se agregará posteriormente a la carpeta de evidencias.

## Ejecución

```bash
dotnet run --project Problema28.csproj
```

Se ingresa el valor de la compra como número (por ejemplo, `250000`) y después si el cliente es frecuente.
