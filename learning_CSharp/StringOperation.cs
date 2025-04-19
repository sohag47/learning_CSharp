using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp
{
    public static class StringOperation
    {
        // here is the details of string and its operations
        public static void Show()
        {
            string name = "Minhaz Islam Sohag";
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Length: {name.Length}");
            Console.WriteLine($"Upper: {name.ToUpper()}");
            Console.WriteLine($"Lower: {name.ToLower()}");
            Console.WriteLine($"Index of 'S': {name.IndexOf('S')}");
            Console.WriteLine($"Last Index of 'S': {name.LastIndexOf('S')}");
            Console.WriteLine($"Substring: {name.Substring(0, 5)}");
            Console.WriteLine($"Trim: {name.Trim()}");
            Console.WriteLine($"Trim Start: {name.TrimStart()}");
            Console.WriteLine($"Trim End: {name.TrimEnd()}");
            Console.WriteLine($"Replace: {name.Replace("Sohag", "Sohag Minhaz")}");
            Console.WriteLine($"Split: {string.Join(", ", name.Split(' '))}");
            Console.WriteLine($"Contains: {name.Contains("Sohag")}");
            Console.WriteLine($"Starts with 'Minhaz': {name.StartsWith("Minhaz")}");
            Console.WriteLine($"Ends with 'Sohag': {name.EndsWith("Sohag")}");
        }
    }
}
