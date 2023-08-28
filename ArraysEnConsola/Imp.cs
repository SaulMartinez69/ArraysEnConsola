using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEnConsola
{
    internal class Imp
    {
        public static void PrintArray(int[] array)
        {
            int ind = 0;
            foreach (int num in array)
            {
                ind++;
                Console.Write(ind + "." + num + "\n");
            }
            Console.WriteLine();
        }
    }
}
