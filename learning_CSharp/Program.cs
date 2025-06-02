

using learning_CSharp.Generics;
using learning_CSharp.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace learning_CSharp
{
    class Program
    {
        static async Task Main()
        {
            // multiple task calling
            //await ImplementAsynchronous.GetDataAsync1();
            //await ImplementAsynchronous.GetDataAsync2();

            // with WhenAll
            var task1 = ImplementAsynchronous.GetDataAsync1();
            var task2 = ImplementAsynchronous.GetDataAsync2();
            await Task.WhenAll(task1, task2);
        }
    }
}
