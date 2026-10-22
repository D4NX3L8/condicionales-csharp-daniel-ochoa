# Problema 30. Boletín de calificaciones

**Estructura elegida:** expresiones `switch` para la letra y la retroalimentación, más condiciones para aprobar y otorgar la mención.
**Justificación:** El promedio se clasifica en rangos de nota; la letra resultante determina el mensaje correspondiente. Las notas se validan dentro del rango 0 a 100 y se muestra una cifra decimal en el promedio.

## Evidencia
La captura de este ejercicio se agregará posteriormente a la carpeta de evidencias.

## Ejecución

```bash
dotnet run --project Problema30.csproj
```

Se ingresan tres notas entre 0 y 100. Se acepta punto decimal, por ejemplo, `85.5`.
