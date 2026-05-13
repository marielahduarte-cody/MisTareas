//Matriz 3x3
int [,] matriz = new int[3,3];

Console.Clear();
Console.WriteLine("Digite los valores de la mtriz 3x3:");
for(int f =0; f < 3; f++)
{
    for (int c =0; c < 3; c++)
    {
        Console.Write($"Elemento [{f},{c}]: ");
        matriz[f,c] = int.Parse(Console.ReadLine()!);
    }
}
Console.WriteLine("Mostrar la matriz");
for(int f =0; f < 3; f++)
{
    for(int c =0; c < 3; c++)
    {
        if (matriz[f, c] % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green; // Pares
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; // Impares
        }
        if (matriz[f, c] < 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Negativos
        }
        Console.Write($"{matriz[f,c]} ");
        
    }
    Console.WriteLine();
}
Console.ResetColor();