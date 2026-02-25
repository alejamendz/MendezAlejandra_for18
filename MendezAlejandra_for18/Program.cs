// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pedir 5 números y mostrar el número mayor ingresado");


int mayor = int.MinValue;

for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingrese número: ");
    int num = int.Parse(Console.ReadLine());

    if (num > mayor)
        mayor = num;
}

Console.WriteLine("Mayor: " + mayor);