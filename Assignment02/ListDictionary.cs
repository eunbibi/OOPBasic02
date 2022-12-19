using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Assignment02
{
    public class ListDictionary
    {
        /*
         * Both list and dictionary belongs to Generic collections
         * Both Dictionary<T> and List<T> can have random access data structures
         * Dictionary: based on Hash table(efficient algorithm to look up things)
         * List: has to check elements by elements till finds the result for beginning, only contains value not key
         */
        public void Func1()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
        }
        // I think to be able to call the list.Add you have to call it from a function or a void (static void main() for example)
        //    https://stackoverflow.com/questions/33421485/list-c-sharp-the-name-list-add-does-not-exist-in-this-context


        /*
        List 
         */
        public void ListTest()
        {
            Console.WriteLine("\nList and Dictionary Test");
            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            Console.WriteLine($"{numbers[0]}, {numbers[3]}");

            // using foreach LINQ method
            numbers.ForEach(num => Console.Write(num + ", "));//prints 1, 2, 5, 7, 8, 10,

            // using for loop
            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i]);
        
            Console.WriteLine("\n");
        }

        public void DictionaryTest()
        {
            // Creating a dictionary
            // using Dictionary<TKey,TValue> class
            Dictionary<int, string> myDict = new Dictionary<int, string>();

            // Adding key/value pairs in the 
            // Dictionary Using Add() method
            myDict.Add(1123, "Welcome");
            myDict.Add(1124, "to");
            myDict.Add(1125, "Seoul");

            // Before Remove() method
            foreach (KeyValuePair<int, string> item in myDict)
            {
                Console.WriteLine($"{item.Key} and {item.Value}");
            }
            Console.WriteLine("-I'm going to remove a key/value pair-");

            // Using Remove() method 
            myDict.Remove(1125);

            // After Remove() method
            foreach (KeyValuePair<int, string> item in myDict)
            {
                Console.WriteLine("{0} and {1}",
                            item.Key, item.Value);
            }
            Console.WriteLine();


            // Using Clear() method
            myDict.Clear();

            Console.WriteLine($"Total number of key/value pairs: {myDict.Count}");
        }

    }
}
