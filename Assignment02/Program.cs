using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using static Assignment02.Enums;

namespace Assignment02
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("----------------------------");
            /*List vs Dictionary studying*/
            ListDictionary ld = new ListDictionary();
            ld.ListTest();
            ld.DictionaryTest();
            
            Console.WriteLine("\n----------------------------");
            /*Generic Dictionary studying*/
            Dictionary_Generic_.DictFunction();

            Console.WriteLine("\n----------------------------");
            /*Out and Ref studying*/
            int refTotal = 20, outTotal = 20;

            Console.WriteLine($"Original: {refTotal}");
            RefAndOut.Add(10, ref refTotal);
            Console.WriteLine($"After: {refTotal}");

            Console.WriteLine();
            Console.WriteLine($"Original: {outTotal}");
            RefAndOut.Add(20, 20, out outTotal);
            Console.WriteLine($"After: {outTotal}");



            Console.WriteLine("\n----------------------------");
            /*Enum studying*/
            Console.WriteLine("\nEnum Test");
            Console.WriteLine("COLOR: {0}, {1}", CaseColor.Blue, (int)CaseColor.Blue);

            CatBreed cat = CatBreed.AmericanShorthair;
            Console.WriteLine(cat);

            //Enum.TryParse() print
            PrintEnum();

            //Asking question example
            int flowerType = AcceptFlowerType();

            while (flowerType == -1)
            {
                Console.WriteLine("\nPlease try again");
                flowerType = AcceptFlowerType();
            }
            if (flowerType != -1)
            {
                Console.WriteLine($"Happy to chose that");
            }


            Console.WriteLine("\n----------------------------");
            /*Inheritance between classes studying*/
            Employee emp = new Employee();
            emp.firstName = "Steve";
            emp.lastName = "Jobs";
            emp.employeeId = 1;
            // error! -> age is a protected level 
            //emp.age = 33;
            emp.companyName = "Apple";

            var fullname = emp.GetFullName(); //Steve Jobs 
            Console.WriteLine(fullname);

            Person personEmp = new Employee();
            Console.WriteLine(personEmp.GetFullName());


            Person p = new Person();
            Console.WriteLine(p.GetFullName());


            Console.WriteLine("\n----------------------------");
            /*Overloading vs Overriding studying*/
            /*
             Overriding occurs when the method signature is the same in the superclass and the child class. 
            Overloading occurs when two or more methods in the same class have the same name but different parameters or datatype.
             */
            int sum1 = Overloading.Add(1, 3);
            int sum2 = Overloading.Add(1, 3, 2);
            Console.WriteLine($"Sum1: {sum1}, Sum2: {sum2}");

            Overloading.Identity("a", 3);
            Overloading.Identity(4, "b");

            Console.WriteLine();
            Overriding2 o = new Overriding2();
            o.showdata();

           
        }
    }
}