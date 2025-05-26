using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.Generics
{
    public interface IEntity
    {
        int Id { get; set; }
    }

    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }

    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public override string ToString() => $"Student: {Name}, ID: {Id}";
    }

    public struct Point
    {
        public int X;
        public int Y;

        public override string ToString() => $"Point({X},{Y})";
    }

    public class Repository<T> where T : BaseEntity, IEntity, new()
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine($"✅ Added: {item}");
        }

        public T CreateNew()
        {
            return new T(); // works because of new() constraint
        }

        public void PrintAll()
        {
            Console.WriteLine("📄 All Items:");
            foreach (var item in items)
            {
                Console.WriteLine($"🔸 {item}");
            }
        }
    }

    public class StructHandler<T> where T : struct
    {
        public void ShowDefault()
        {
            T value = default;
            Console.WriteLine($"🧮 Struct default value: {value}");
        }
    }
}
