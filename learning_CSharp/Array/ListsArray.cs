using learning_CSharp.OOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.Array
{
    public static class ListsArray
    {
        public static void Show()
        {
            // Basic List
            //List<string> users = new List<string>() { "minhaz", "sohag", "Oppo" };
            //users.Add("Asif");
            //Console.WriteLine($"Length: {users.Count}");
            //users.Remove("Asif");
            //users.Sort();
            //Console.WriteLine($"Find Asif: {users.Contains("Asif")}");

            //foreach (var item in users)
            //{
            //    Console.WriteLine(item);

            //}

            // Advance List
            User user1 = new(1, "sohag", "sohag@email.com");
            User user2 = new(2, "sohan", "sohan@email.com");
            User user3 = new(3, "asif", "asif@email.com");

            List<User> users = [user1, user2, user3];

            foreach (var item in users)
            {
                Console.WriteLine($"{item.ID}, {item.Name}, {item.Email}");
            }

        }
    }

    class User(int _id, string _name, string _email)
    {
        public int ID { get; set; } = _id;
        public string Name { get; set; } = _name;
        public string Email { get; set; } = _email;
    }
}
