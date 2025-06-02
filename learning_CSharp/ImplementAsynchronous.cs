using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp
{
    public static class ImplementAsynchronous
    {
        public static async Task GetDataAsync1()
        {
            await Task.Delay(1000);
            Console.WriteLine("Done from 1!");
        }
        public static async Task GetDataAsync2()
        {
            await Task.Delay(1000);
            Console.WriteLine("Done form 2!");
        }
    }
}
