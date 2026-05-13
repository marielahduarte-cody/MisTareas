//Una empresa de logística utiliza un sistema de posicionamiento para registrar desplazamientos realizados por un dron durante cinco intervalos de tiempo.
//El sistema necesita sumar dos vectores para calcular el desplazamiento total acumulado.

int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] vectorsuma = new int[5];

Console.Clear();
Console.WriteLine("Tio ingresa los valores del primer vector");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.WriteLine($"Valor {i + 1}:");
        vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Entrada no valida.Por favor, ingresa un número, Pli :C.");
        i--; // Decrementar el índice para volver a solicitar el valor
        Console.ResetColor();
    }
}

Console.WriteLine("Tio ingresa el valor del segundo vector, ostia :D");
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
    //Suma los vectores
    for(int i = 0; i < vectorsuma.Length; i++)
    {
        vectorsuma[i] = vector1[i] + vector2[i];
    }

    //Muestra el arreglo resultante
    Console.WriteLine("Suma de vectores: ");
    for (int i = 0; i < vectorsuma.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Valor {i + 1}: {vectorsuma[i]}");
    }
    Console.ResetColor();