using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Overloading
    {
        ////
        ///Method Overloading is the common way of implementing polymorphism
        ///Redefine two or more functions with same name
        ///same name but the different number of parameters, other datatype

        public static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public static int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        //=================================================
        public static void Identity(String name, int id)
        {

            Console.WriteLine("Name1 : " + name + ", "
                            + "Id1 : " + id);
        }

        public static void Identity(int id, String name)
        {

            Console.WriteLine("Name2 : " + name + ", "
                            + "Id2 : " + id);
        }
    }
}
