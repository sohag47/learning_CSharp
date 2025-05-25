using learning_CSharp.Database.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace learning_CSharp.Database
{
    public class DB
    {
        public static void Show()
        {
            using ApplicationDbContext context = new();

            //creates db if not exists 
            //context.Database.EnsureCreated();

            //create entity objects
            //Grade grd1 = new() { Name = "1st Grade" };


            //add entitiy to the context
            //context.Grades.Add(grd1);

            //save data to the database tables
            //context.SaveChanges();

            ////retrieve all the students from the database
            //foreach (Grade grade in context.Grades)
            //{
            //    Console.WriteLine($"Name: {grade.Name}");
            //}
            var CreatedAt = new DateTime(2025, 5, 20, 17, 10, 19, DateTimeKind.Utc);
            User usr = new() { Name = "Mahim", Email = "mahim@email.com", Id = 3, CreatedAt = CreatedAt };
            context.Users.Add(usr);
            context.SaveChanges();

            var users = context.Users.ToList();

            foreach (var user in users)
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }
    }
}
