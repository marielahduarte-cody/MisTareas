// El equipo de ingeniería necesita calcular la magnitud total del vector de movimiento para validar la trayectoria recorrida.

int[] vector = new int[5];
int sumaCuadrados = 0;
double magnitud = 0;

Console.Clear();
Console.WriteLine("Tio, ingresa los valores del vector, Pli :D");
for (int i = 0; i < vector.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector[i] = int.Parse(Console.ReadLine()!);
}
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar la entrada
    }
    sumaCuadrados += vector[i] * vector[i];// Suma de los cuadrados de los elementos del vector

    magnitud = Math.Sqrt(sumaCuadrados);
}

    Console.WriteLine($"La magnitud total de el vector en movimiento es {magnitud}");
