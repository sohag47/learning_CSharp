
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
            IPrintable[] printables = new IPrintable[1];
            printables[0] = new Book("First Book", "Sohag");

            foreach(IPrintable item in printables)
            {
                item.PrintDetails();
                item.LogError("Something went wrong!");
            }

            //Book book = new("First Book", "Sohag");
            //book.PrintDetails();
        }
    }
}
