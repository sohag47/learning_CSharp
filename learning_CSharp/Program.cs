
using learning_CSharp.Generics;
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
        static void Main()
        {
            Repository<Student> studentRepo = new Repository<Student>();
            Student s1 = new() { Id = 1, Name = "Rakib" };
            Student s2 = new () { Id = 2, Name = "Mahi" };

            studentRepo.Add(s1); 
            studentRepo.Add(s2);

            studentRepo.PrintAll();

            Student newStudent = studentRepo.CreateNew();
            Console.WriteLine($"🆕 Created new student (empty): {newStudent}");

            Console.WriteLine();

            // Using struct-specific class
            StructHandler<Point> pointHandler = new StructHandler<Point>();
            pointHandler.ShowDefault();
        }
    }
}
