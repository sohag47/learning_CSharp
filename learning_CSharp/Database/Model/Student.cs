using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.Database.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
