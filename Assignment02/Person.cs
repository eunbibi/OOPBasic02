using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Person
    {
        //properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        //access modifier exercise
        protected int age { get; set; } //-> it can be use in the Employee class level, but not in the Program class level
        private string dob { get; set; }   //-> only works in this class


        //method
        public string GetFullName()
        { 
            return firstName+ " " + lastName;
        }
    }
}
