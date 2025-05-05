using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp
{
    class Person
    {
        public int id;
        public string name;
        public int age;

        public Person(int _id, string _name, int _age)
        {
            id = _id;
            name = _name;
            age = _age;
        }
        public void Profile()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }
    }
    class Program
    {
        static void Main()
        {
            Person user1 = new Person(1, "Minhazul", 10);
            user1.Profile();
            

            Person user2 = new(2, "Miraz", 30);
            user2.Profile();
           
        }
    }
}
