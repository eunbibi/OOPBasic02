using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class Dictionary_Generic_
    {
        //declare generic collection
        public static Dictionary<string, string> movie = new Dictionary<string, string>();

        public static void DictFunction()
        { 
            //adding item in collection
            movie.Add("sci-fi", "Interstella");
            movie.Add("Action", "Fast and furios");
            movie.Add("Fantacy", "Harry Potter");
            movie.Add("Computer", "Immitaion game");
            movie.Add("Love", "About time");

            //Printing single item
            Console.WriteLine(movie["sci-fi"]);

            //Iterate Dictionary
            foreach (KeyValuePair<string, string> items in movie)
            {
                Console.WriteLine(items.ToString());
            }

            //Find items
            string input = Console.ReadLine();
            if (movie.ContainsKey(input))
            {
                Console.WriteLine($"Key found. Value is {movie[input].ToString()} ");
            }
            else
            {
                Console.WriteLine("Key Not Found");
            }
        }
    }
}
