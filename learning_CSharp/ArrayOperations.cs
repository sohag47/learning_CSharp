using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp
{
    public static class ArrayOperations
    {
        // here is the details of array and its operations    
        public static void Show()
        {
            // 1. Single-Dimensional Array    
            int[] numbers = { 1, 2, 3, 4, 5 }; // Simplified collection initialization    
            string[] users = { "Sohag", "Minhaz", "Shakil" }; // Simplified collection initialization  
            foreach (var item in users)
            {
                Console.WriteLine($"item: {item}");
            }
            Console.WriteLine($"Length is: {users.Length}");


            //  2. Multi-Dimensional Array (Rectangular)    
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(matrix[0, 1]);
        }
    }
}
