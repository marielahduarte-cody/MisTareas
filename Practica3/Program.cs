//Un jugador desea almacenar los puntajes obtenidos en diferentes partidas.

int[] puntajes = new int[6];
int puntajeMaximo = 0;
int conteo = 0;

Console.WriteLine("Ingrese los 6 puntajes de las partidas: ");
for (int i =0; i < 6; i++)
{
    Console.Write($"Puntaje obtenido en la partida {i+1}: ");
    puntajes[i]= int.Parse(Console.ReadLine()!);

}
Console.WriteLine("\nLos puntajes obtenidos en las partidas son: ");

//Mostrar los puntajes

foreach (int puntaje in puntajes)
{
    Console.WriteLine(puntaje);
}

//Puntaje mas alto

puntajeMaximo = puntajes[0];
for (int i = 1; i < puntajes.Length; i++)
{
    if (puntajes[i] > puntajeMaximo)
    {
        puntajeMaximo = puntajes[i];
    }
}
Console.WriteLine($"\nEl puntaje mas alto es: {puntajeMaximo}");

//Ordenar de menor a mayor
Array.Sort(puntajes);
Console.WriteLine("Los puntajes ordenados de menor a mayor son:");
foreach (int puntaje in puntajes)
{
    Console.WriteLine(puntaje);
}

conteo= 0;
for (int i = 0; i < puntajes.Length; i++)
{
    if (puntajes[i] > 500)
    {
        conteo++;
    }
}
Console.WriteLine($"\nEl numero de puntajes mayores a 500 es: {conteo}");