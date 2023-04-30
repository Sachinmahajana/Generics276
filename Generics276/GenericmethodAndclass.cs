using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics276
{
    internal class GenericmethodAndclass<E>
    {
        public static void ToPrint(E[] arr)
        {
            Console.WriteLine("Array Elements");
            foreach(E e in arr)
            {
                Console.WriteLine(e + " ");
            }
        }
    }
}
