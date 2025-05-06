using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_CSharp.OOP
{
    class User
    {
        private string uuid; // field

        public string Uuid // property
        {
            get { return uuid; } // method
            set { uuid = value; } // method
        }
        public bool IsAdmin { get; set; } // Automatic Properties (Short Hand)

    }
}
