// El objetivo es calcular el producto escalar entre ambos vectores para analizar su comportamiento.

int[] vector1 = new int [5];
int[] vector2 = new int [5];
double productoEscalar = 0;

Console.Clear();
Console.WriteLine("Ingresa los valores del primer vector:");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine()!);
}
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar la entrada
    }
}

Console.WriteLine("Tio ingresa el valor del segundo vector, vale :D");
for (int i =0; i < vector2.Length; i++)
{
    try
    {
        Console.WriteLine($"Valor {i + 1}: ");
        vector2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Entrada no valida.Por favor, ingresa un número, Pli :C.");
        i--; // Decrementar el índice para volver a solicitar el valor
        Console.ResetColor();
    }

    //Producto escalar

    productoEscalar += vector1[i] * vector2[i];
}

Console.WriteLine($"El producto escalar entre ambos vectores es: {productoEscalar}");