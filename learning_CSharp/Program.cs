using learning_CSharp.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
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
            //Person user1 = new Person(1, "Minhazul", 10);
            //user1.Profile();


            //Person user2 = new(2, "Miraz", 30);
            //user2.Profile();

            User user = new(1,"Sohag","sohag@emial.com");
            Console.WriteLine(user.Profile());
            user.Second();
        }
    }
}
