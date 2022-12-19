using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Rectangle
    {
        //member variables
        private double length;
        private double width;

        //getter and setter
        //its a property
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }


        public void Acceptdetails()
        {
            Length = 10;
            width = 14;
        }

        public double GetArea()
        {
            return Length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle
}
