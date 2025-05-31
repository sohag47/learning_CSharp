using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.LINQ
{
    // sql syntex
    //var evenNumbers = from number in numbers where number % 2 == 0 select number;

    // c# syntex
    //var evenNumbers = numbers.Where(number => number % 2 == 0);
    public class ImplementLinq
    {
          
        public static void Print(IEnumerable<string> evenNumbers)
        {
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }
        public class Product()
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        public static void Execute()
        {
              
            List<string> users = ["Hasan", "Rakib", "Anik", "Bappa"];

            IEnumerable<string> sortedNames = users
                              .Where(n => n.Contains('a'))
                              .OrderBy(n => n)
                              .Select(n => n.ToUpper());

            //Print(sortedNames);

            List<int> numbers = [1, 2, 3, 4, 5];
            int count = numbers.Count;
            Console.WriteLine("Total: " + count);

            int total = numbers.Sum();
            Console.WriteLine("Sum: " + total);

            double avg = numbers.Average();
            Console.WriteLine("Average: " + avg);

            int min = numbers.Min();
            int max = numbers.Max();
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);

            int result = numbers.Aggregate((acc, n) => acc * n); // 1*2*3*4*5 = 120
            Console.WriteLine("Product: " + result);

            var unique = numbers.Distinct();
            Console.WriteLine(string.Join(", ", unique));

            ArrayList mixed = new ArrayList { 1, "Hello", 2, "World", 3.5 };

            var onlyIntegers = mixed.OfType<int>();
            foreach (var i in onlyIntegers)
            {
                Console.WriteLine(i);
            }

            var evenList = numbers.Where(n => n % 2 == 0).ToList();
            int[] evenArray = numbers.Where(n => n % 2 == 0).ToArray();

            List<Product> products = [
                new Product { Name = "Pen", Price = 10 },
                new Product { Name = "Book", Price = 50 }
            ];
            var dict = products.ToDictionary(p => p.Name, p => p.Price);

            Console.WriteLine(dict["Pen"]);
        }
    }
}
