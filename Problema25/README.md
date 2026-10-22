# Problema 25. Calidad del aire

**Estructura elegida:** expresión `switch` con patrones relacionales.
**Justificación:** Los límites superiores se evalúan en orden, de modo que cada ICA queda en una sola categoría y los valores negativos se separan explícitamente como inválidos.

## Evidencia
La captura de este ejercicio se agregará posteriormente a la carpeta de evidencias.

## Ejecución

```bash
dotnet run --project Problema25.csproj
```

El ICA entero se ingresa por consola.
