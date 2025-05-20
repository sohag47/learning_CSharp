using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp
{
    public static class GenericType
    {
        public static void Implements()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] names = { "sohag", "sohan", "asif" };
            Show(numbers);
            Show(names);
        }
        public static void Show<T>(T[] data)
        {

            foreach (T item in data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
       
    }
}
