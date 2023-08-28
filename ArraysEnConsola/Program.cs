using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEnConsola
{
    internal class Program : Imp
    {
        int axs = 0;
        static void Main(string[] args)
        {
            //Variables
            int x = 0, menu = 0;
            Random rm = new Random();

            Console.WriteLine("Ingresa el tamaño del arreglo");
            x = int.Parse(Console.ReadLine()); Console.Clear();
            Console.WriteLine("Selecciona Una Opción\n1.Ordenar de menor a mayor\n2.Ordenar de mayor a menor\n3.Mostrar en orden por indice \n4.Extraer todo los números mayores a un número ingresado");
            menu = int.Parse(Console.ReadLine()); Console.Clear();
            //Asigno valor a cada espacio del arreglo
            int[] array1 = new int[x];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rm.Next(-100000, 100000);
            }
            switch (menu)
            {
                //Ordenar de menor a mayor
                case 1:
                    for (int i = 0; i < array1.Length - 1; i++)
                    {
                        for (int j = i + 1; j < array1.Length; j++)
                        {
                            if (array1[i] > array1[j])
                            {
                                int temp = array1[i];
                                array1[i] = array1[j];
                                array1[j] = temp;
                            }
                        }
                    }
                    Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
                    PrintArray(array1);
                    break;
                case 2:
                    for (int i = 0; i < array1.Length - 1; i++)
                    {
                        for (int j = i + 1; j < array1.Length; j++)
                        {
                            if (array1[i] < array1[j])
                            {
                                int temp = array1[i];
                                array1[i] = array1[j];
                                array1[j] = temp;
                            }
                        }
                    }
                    Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
                    PrintArray(array1);
                    break;
                case 3:
                    //Imprimimos los valores por orden
                    int indice = 1;
                    for (int i = 0; i < array1.Length; i++)
                    {
                        Console.WriteLine("Indice " + indice + ": " + array1[i]);
                        indice++;
                    }
                    break;
                case 4:
                    int bs = 0, ind=1;
                    Console.WriteLine("Ingresa el número base");
                    bs = int.Parse(Console.ReadLine());
                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (array1[i]>bs)
                        {
                            Console.WriteLine("Posición " + i + ": " + array1[i]);
                            ind++;
                        }
                    }
                    break;
            }
            Console.ReadKey();
        }

    }
}
