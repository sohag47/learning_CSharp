
using learning_CSharp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using learning_CSharp.OOP;


namespace learning_CSharp
{
    class Program
    {
        static void Main()
        {
            Dog dog = new();
            dog.MakeSound();
            dog.Eat();


            Cat cat = new();
            cat.MakeSound();
            cat.Eat();
        }
    }
}
