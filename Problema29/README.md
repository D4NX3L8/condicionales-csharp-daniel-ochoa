# Problema 29. Control de acceso a la sede

**Estructura elegida:** expresión `switch` con patrones relacionales y operador lógico `&&`.
**Justificación:** La decisión depende del rol y del intervalo horario correspondiente. Primero se valida que la hora esté entre 0 y 23; luego se aplican los permisos específicos de cada rol.

## Evidencia
La captura de este ejercicio se agregará posteriormente a la carpeta de evidencias.

## Ejecución

```bash
dotnet run --project Problema29.csproj
```

El rol y la hora se ingresan por consola.
