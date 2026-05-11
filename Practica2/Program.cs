//Una tienda desea registrar las ventas diarias de una semana.
double ventasdiarias= 0;
string dias = "Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo";
double totalvendido = 0;
int diasSuperiores150 = 0;
double ventaMinima = 0;

Console.WriteLine("Ingrese las ventas diarias de la semana:");
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Ingrese las ventas del dia {dias.Split(",")[i]}");
    ventasdiarias = Convert.ToDouble(Console.ReadLine()!);

    totalvendido += ventasdiarias;
        if (ventasdiarias > 150)
        {
            diasSuperiores150++;
        }
        if (ventasdiarias < ventaMinima || i == 0)
        {
            ventaMinima = ventasdiarias;
        }
}

Console.WriteLine($"El total vendido en la semana es {totalvendido}");
Console.WriteLine($"El numero de dias con ventas superiores a 150 es {diasSuperiores150}");
Console.WriteLine($"La venta minima registrada en la semana es {ventaMinima}");