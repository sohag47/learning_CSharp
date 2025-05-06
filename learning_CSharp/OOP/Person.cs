using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.OOP
{
    class Person
    {
        /// <summary>
        /// public fields read and write outside the class
        /// private fields not read and write outside the class
        /// </summary>
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
}
