# Problema 23. Inicio de sesión

**Estructura elegida:** condicionales `if` anidados.
**Justificación:** El acceso se valida en dos pasos: solo se solicita y comprueba la contraseña si el usuario existe. Cada fallo muestra su propio mensaje.

## Evidencia
La captura de la ejecución en terminal está en [evidencias/image.png](evidencias/image.png).

## Ejecución

```bash
dotnet run --project Problema23.csproj
```

Primero se ingresa el usuario y, si es `aprendiz`, se solicita la contraseña.
