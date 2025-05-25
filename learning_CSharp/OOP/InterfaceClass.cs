using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.OOP
{
    public interface IPrintable
    {
        void PrintDetails();

        void LogError(string error)
        {
            Console.WriteLine($"[ERROR Default]: {error}");
        }
    }

    public class Book : IPrintable
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Printing Book: {Title} by {Author}");
        }

        public void LogError(string error)
        {
            Console.WriteLine($"[FILE ERROR]: {error}");
        }
    }
}
