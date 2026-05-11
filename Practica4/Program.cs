//Una librería necesita registrar las ventas de libros por categoría.
string[] categorias = {"Novelas", "Ciencia", "Historia","Infantiles","Tecnología"};

int[] ventas = new int[5]; int totalVentas = 0;
int mayorVenta; int posicionMayor = 0;
double promedio =0;

Console.WriteLine("Inventario de ventas por categoria: ");
for (int i = 0; i < ventas.Length; i++)
{
    Console.Write($"Ingrese la cantidad de libros vendidos en {categorias[i]}: ");
    ventas[i] = int.Parse(Console.ReadLine()!);

    totalVentas += ventas[i];
}

mayorVenta = ventas[0];
for (int i = 1; i < ventas.Length; i++)
{
    if (ventas[i] > mayorVenta)
    {
        mayorVenta = ventas[i];
        posicionMayor = i;
    }
}

promedio = (double)totalVentas / ventas.Length;

Console.WriteLine($"\nTotal de ventas: {totalVentas}");
Console.WriteLine($"Promedio de ventas por categoría: {promedio:F2}");
Console.WriteLine($"Categoría con más ventas: {categorias[posicionMayor]}");
Console.WriteLine($"Cantidad vendida: {mayorVenta}");
Console.WriteLine($"Promedio de ventas: {promedio:F2}");