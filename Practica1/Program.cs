//Una estación meteorológica necesita registrar las temperaturas máximas de 7 días.

int[] temperaturasMaximas = new int [7];
int sumaTemperaturas = 0;
double promedio = 0;
int temperaturamasalta =0;
int temperaturamasbaja = 0;

for (int i =0; i < temperaturasMaximas.Length; i++)
{
    Console.WriteLine($"Ingrese el valor de la temperatura máxima del día {i + 1}: ");
    temperaturasMaximas[i] = int.Parse(Console.ReadLine()!);
    sumaTemperaturas += temperaturasMaximas[i];
}

Console.WriteLine("Las temperaturas máximas registradas son: ");
for (int i = 0; i < temperaturasMaximas.Length; i++)
{
    Console.WriteLine($"Día {i + 1}: {temperaturasMaximas[i]}C");
}

//Promedio de las temperaturas
promedio = sumaTemperaturas / temperaturasMaximas.Length;
Console.WriteLine($"El promedio de las temperaturas es: {promedio}C");

//Indicar la temperatura mas alta.
temperaturamasalta = temperaturasMaximas[0];
for (int i = 1; i < temperaturasMaximas.Length; i++)
{
    if (temperaturasMaximas[i] > temperaturamasalta)
    {
        temperaturamasalta = temperaturasMaximas[i];
    }
}
Console.WriteLine($"La temperatura más alta es: {temperaturamasalta}C");

//Indicar la temperatura mas baja.
temperaturamasbaja = temperaturasMaximas[0];
for (int i = 1; i < temperaturasMaximas.Length; i++)
{
    if (temperaturasMaximas[i] < temperaturamasbaja)
    {
        temperaturamasbaja = temperaturasMaximas[i];
    }
}
Console.WriteLine($"La temperatura más baja es: {temperaturamasbaja}C");
