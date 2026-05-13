//Matriz 5 x 5. El usuario debe buscar un nunero y si lo encuentra mostrarlo en verde si

int[,] matriz = new int[5,5];

Console.Clear();
Console.WriteLine("Digite los valores de la mtriz 5x5:");
for(int f =0; f < 5; f++)
{
    for (int c =0; c < 5; c++)
    {
        Console.Write($"Elemento [{f},{c}]: ");
        matriz[f,c] = int.Parse(Console.ReadLine()!);
    }
}
Console.WriteLine("Mostrar la matriz");
for(int f =0; f < 5; f++)
{
    for(int c =0; c < 5; c++)
    {
        Console.Write($"{matriz[f,c]} ");
    }
    Console.WriteLine();
}

