//Un sistema de monitoreo industrial registra diferencias de producción entre dos máquinas durante cinco períodos consecutivos. 
//El departamento técnico necesita calcular la diferencia entre ambos vectores.

int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] vectoresta = new int[5];

Console.Clear();
Console.WriteLine("Ingrese el valor de el primer vector 1:");
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
   
}
    //Resta los vectores
    for(int i = 0; i < vectoresta.Length; i++)
    {
        vectoresta[i] = vector1[i] - vector2[i];
    }

    //Muestra el arreglo resultante
    Console.WriteLine("Resta de vectores: ");
    for (int i = 0; i < vectoresta.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Valor {i + 1}: {vectoresta[i]}");
    }
    Console.ResetColor();