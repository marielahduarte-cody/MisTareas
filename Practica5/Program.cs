//Un profesor necesita almacenar las calificaciones finales de sus estudiantes.

double[] notas = new double[8];
double promedio =0;
double suma =0;
int reprobados =0;

for (int i =0; i < notas.Length; i++)
{
    Console.WriteLine($"Ingrese la nota del estudiante {i +1}");
    notas[i] = Double.Parse(Console.ReadLine()!);
    suma += notas[i];

if (notas[i] < 60)
{
    Console.WriteLine($"El estudiante {i +1} ha reprobado con una nota de {notas[i]}");
    reprobados++;
}
else
{
    Console.WriteLine($"El estudiante {i +1} ha aprobado con una nota de {notas[i]}");
}
}
//notas aprobadas
for(int i =0; i < notas.Length; i++)
{
    if (notas[i] >= 60)
    {
        Console.WriteLine($"El estudiante {i +1} aprobo con {notas[i]}");
    }
}

promedio = suma / notas.Length;

Console.WriteLine($"Promedio general del grupo: {promedio:F2}");
Console.WriteLine($"Cantidad de estudiantes reprobados: {reprobados}");
