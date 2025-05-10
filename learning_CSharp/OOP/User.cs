using learning_CSharp.OOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.OOP
{
    class User(int _id, string _name, string _email) : IUser, ISecond
    {
        public int ID { get; set; } = _id;
        public string Name { get; set; } = _name;
        public string Email { get; set; } = _email;

        public string Profile()
        {
            return $"ID: {ID}, Name: {Name}, Email: {Email}";
        }
        public void Second()
        {
            Console.WriteLine("Seond Interface");
        }
    }
}
