using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp
{
    public class LambdaExpressions
    {
        public static void Show()
        {
            
            // not return any value
            Action greet = () => Console.WriteLine("Welcome!");
            greet();

            Action<string> profile = (name) => Console.WriteLine($"Hello, {name}");
            profile("Sohag");

            // return 
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine("Multiple: " + add(5, 4));
        }
    }
}
