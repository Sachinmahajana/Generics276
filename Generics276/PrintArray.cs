using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Generics276
{
    internal class PrintArray
    {
        public static void ToPrint(int[] intArray)
        {
            Console.WriteLine("integers Array elements");
            foreach(int element in intArray)
            {
                Console.WriteLine(element + " ");
            }
        }
        public static void ToPrint(double[] doubleArray)
        {
            Console.WriteLine("double array elements");
            foreach(double element in doubleArray)
            {
                Console.WriteLine(element + " ");
            }
        }
        public static void ToPrint(char[] charArray)
        {
            Console.WriteLine("char array elements");
            foreach(char element in charArray)
            {
                Console.WriteLine(element + " ");
            }
        }

    }
}
