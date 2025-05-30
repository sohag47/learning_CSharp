using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.Generics
{
    public static class ImplementDictionary
    {
        public static void Print(Dictionary<int, string> students)
        {
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }


        public static void Execute()
        {
            // Assign List  
            Dictionary<int, string> students = new();

            // add data  
            students.Add(1, "Sohag");
            students.Add(2, "Sohan");
            students.Add(3, "Asif");
            students.Add(4, "Arman");
            students.Add(5, "Fahmida");

            // show list items  
            Print(students);
            if (students.ContainsKey(1))
            {
                Console.WriteLine("Role Found");
            }
            students.Remove(1);
            if (students.TryGetValue(2, out string? name))
            {
                Console.WriteLine("Name: " + name);
            }else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
