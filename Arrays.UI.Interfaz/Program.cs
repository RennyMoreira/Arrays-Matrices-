

using MyArray.Logic;
using System;
using System.Numerics;

try
    
{
    var array = new Arreglos(10);
    array.Fill(1, 10);
    array.Sort();
    Console.WriteLine(array);
    
    Console.WriteLine("\n\n\n\t\t\t\t==================MENÚ  ARRAYS=============\n\n");
    string opcion;
    do
    {
        Console.WriteLine("1.- Agregar un número");
        Console.WriteLine("2.- Insertar un número");
        Console.WriteLine("3.- Llenar matriz");
        Console.WriteLine("4.- Números primos");
        Console.WriteLine("5.- Números pares");
        Console.WriteLine("6.- Números repetidos");
        Console.WriteLine("7.- Números  no repetidos");
        Console.WriteLine("8.- Números  más repetidos");
        Console.WriteLine("9.- Salir");
        opcion = Console.ReadLine();
        string i = null;
        switch (opcion)
        {

            case "1":

                Console.WriteLine("Ingrese la cantidad de números: ");
                Console.WriteLine(array);
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(array);
                break;

            case "2":
                Console.WriteLine("Inserte un número: ");
                Console.WriteLine(array);
                int _array = int.Parse(Console.ReadLine());
                Console.Write(array);
                array.Sort();
                Console.WriteLine(array);

                break;

            case "3":
                Console.WriteLine(array);
                Console.WriteLine("Ingrese los datos para llenar una matriz: ");
                Console.Write("Ingrese valor:");
                String linea;
                linea = Console.ReadLine();
                array = new Arreglos();
                array.Agregar();
                array.Sort();
                break;

            case "4":
                Console.WriteLine(array);
                Console.WriteLine("=============Primos============");
                var getPrimos = array.Primo();
                Console.WriteLine(getPrimos.N);
                break;

            case "5":
                Console.WriteLine(array);
                Console.WriteLine("===========Pares==========");
                var getPares = array.Pares();
                Console.WriteLine(getPares);
                break;

            case "6":
                Console.WriteLine(array);
                Console.WriteLine("===============Repetidos===============");
                var siRepetidos = array.Repetidos();
                siRepetidos.Sort();
                Console.WriteLine(siRepetidos);
                break;

            case "7":
                Console.WriteLine(array);
                Console.WriteLine("===============NoRepetidos===============");
                var nonRepet = array.NotRepetidos();
                nonRepet.Sort();
                Console.WriteLine(nonRepet);
                break;

            case "8":
                Console.WriteLine(array);
                Console.WriteLine("===========Más Repetidos===================");
                var newMoreRepit = array.MoreNUmberRepit();
                Console.WriteLine($"Los números que más se repiten son: \n {newMoreRepit}");
                break;
            default:
                break;
        }
    }
    while (opcion != "9");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}






