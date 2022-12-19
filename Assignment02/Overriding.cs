using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{

    //lets say its a base class 부모클래스
    //ex) Chef class

    public class Overriding
    {
        ////
        ///부모에서 정의된 멤버 메서드를 자식에서 재정의 하는 것
        ///Overriding is a feature that allows subclass or child class
        ///to provide a specific implementation of a method that is 
        ///already provided by one of its super class.
        ///

        // overloding: same name of method name can be defined as long as two conditional met
        //1. Parameter count is different 2. Parameter count is the same but Data type is different
        
        //overriding: On the inheritance concept, if parent method defined virtual keyword derived class can override method
        //오버로딩 하며 오버라이딩 가능
        //
        string intro = "I'm a chef";

        // 'showdata()' is member method,
        // declare as a virtual
        //virtual = "overidable"
        public virtual void showdata()
        {
            Console.WriteLine($"Job: {intro}");
        }
    }

    //lets say its a derived class 자식클래스
    //ex) Italian chef class
    public class Overriding2 : Overriding
    {
        string s = "I'm an Italian chef";

        //'showdata()' is overridden
        // in derived class
        public override void showdata()
        {

            // Calling 'showdata()' of base
            // class using 'base' keyword
            base.showdata();

            Console.WriteLine($"Specialty: {s}" );
        }
    }

}
