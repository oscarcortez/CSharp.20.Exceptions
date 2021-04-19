# CSharp.20.Exceptions

Es un evento que ocurre durante la ejecucion de un programa y que interrumpe el flujo normal de la operacion

tiene los siguientes bloques:
- try: es el bloque que se revisa
- catch: es el bloque que captura el error, puede haber catch anidados
- finally: es el bloque de codigo que se ejecuta haya o no error, mayormente se usa para liberar memoria
- throw: se utiliza para lanzar errores detectados manualmente

```csharp
try
{
  result = num1 / num2;
}
catch (DivideByZeroException e)
{
  Console.WriteLine($"Exception caught: {e}");                
}
finally
{
  Console.WriteLine($"Result: {result}");
}
```
