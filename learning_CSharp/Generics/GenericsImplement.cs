using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.Generics
{
    public class IntContainer
    {
        public int Value;
    }

    public class MyContainer<T>
    {
        public T? Value { get; set; }


        public void Print()
        {
            Console.WriteLine(Value);
        }
    }

    public class Utility
    {
        public void Print<T>(T item)
        {
            Console.WriteLine(item);
        }
    }

    //public class Repository<T> where T : class
    //{
    //    public void Add(T item)
    //    {
    //        Console.WriteLine($"{item}");
    //    }
    //}

    //public class Student
    //{
    //    public string Name { get; set; }
    //    public override string ToString()
    //    {
    //        return $"Student: {Name}";
    //    }
    //}
}
