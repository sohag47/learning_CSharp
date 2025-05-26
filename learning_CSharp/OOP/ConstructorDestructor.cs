using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.OOP
{
    public class Student
    {
        public string name;

        public Student() : this("Unknown")
        {
            Console.WriteLine("Default constructor called");
        }

        public Student(string name)
        {
            Console.WriteLine("Constructor called");
            this.name = name;
            Console.WriteLine(name);
        }

        

        ~Student()
        {
            Console.WriteLine("Destructor called");
        }
    }
}
