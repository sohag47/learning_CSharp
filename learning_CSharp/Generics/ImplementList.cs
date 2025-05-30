using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.Generics
{
    public static class ImplementList
    {
        public static void Print(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i}. ID: {users[i].ID}, Name: {users[i].Name}, Email: {users[i].Email}");
            }
        }

        public static User? FindOrFail(List<User> users, Func<User, bool> predicate)
        {
            return users.FirstOrDefault(predicate);
        }

        public static void Execute()
        {
            // Assign List  
            List<User> users = new List<User>();

            // add data  
            User user1 = new(1, "sohag", "sohag@email.com");
            users.Add(user1);
            User user2 = new(2, "sohan", "sohan@email.com");
            users.Add(user2);
            User user3 = new(3, "asif", "asif@email.com");
            users.Add(user3);
            User user4 = new(4, "Arman", "arman@email.com");
            User user5 = new(5, "Fahmida", "fahmida@email.com");
            users.Insert(3, user4); // Corrected: Insert requires an index and an item  
            users.Insert(4, user5);

            // show list items  
            Print(users);
            int fahmida_index = users.IndexOf(user5);
            Console.WriteLine(fahmida_index);

            users.Remove(user5);
            Print(users);

            var result = FindOrFail(users, u => u.ID == 5);
            if (result != null)
                Console.WriteLine($"Found: {result.ID}, {result.Name}, {result.Email}");
            else
                Console.WriteLine("User not found.");
        }
    }
}
