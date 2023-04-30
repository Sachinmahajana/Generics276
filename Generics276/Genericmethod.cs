using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics276
{
    internal class Genericmethod
    {
        public static void ToPrint<T>(T[] intArray)
        {
            Console.WriteLine("Displaying Array elements");
            foreach(T element in intArray)
            {
                Console.WriteLine(element + " "); 
            }
        }
    }
}
