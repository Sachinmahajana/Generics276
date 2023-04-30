using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics276
{
    internal class Genericclass<E>
    {
        public E[] arr;

        public Genericclass(E[] arr)
        {
            this.arr = arr;
        }
        public void Toprint()
        {
            Console.WriteLine("Array Elements");
            foreach(E element in arr)
            {
                Console.WriteLine(element + " ");
            }
        }
           

    }
}
