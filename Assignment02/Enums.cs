using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Enums
    {
        ///Enum.Parse: A method that convert String to Enum

        //An enum type internally contains an enumerator list.
        //The values(e.g.Trivial, Critical) are ints like 1 and 4.
        public enum CaseColor
        {
            Uncolored = 0,
            Red = 8001,
            Blue = 9001
        }
        public enum CatBreed
        {
            Siamese,
            AmericanShorthair,
            Ragdoll,
            RussianBlue,
            Etc
        }
        public enum FlowersType
        {
            None,
            Daisy = 1,
            Lily = 2,
            Rose = 3,
            Freesia = 4
        }

        //Try.Parse() Print example
        public static void PrintEnum()
        {
            FlowersType flower;

            if (Enum.TryParse("Rose", out flower))
            {
                Console.WriteLine($"\nTest1: {flower == FlowersType.Rose}");
            }
            if (Enum.TryParse("9", out flower))
            {
                Console.WriteLine($"Test2: {FlowersType.Daisy}");
            }
            if (Enum.TryParse("4", out flower))
            {
                Console.WriteLine($"Test3: {flower}");
            }
        }


        public static int AcceptFlowerType()
        {
            int x = AskQuestionInt("\n1. Daisy\n2. Lily\n3. Rose\n4. Freesia\nPlease enter the flower number: ");
            return Enum.IsDefined(typeof(FlowersType), x) ? x : -1; //teneray operATOR
        }

        static public int AskQuestionInt(string question)
        {
            //모든 데이터 타입은 parse를 갖음
            System.Console.Write(question);
            bool state = int.TryParse(System.Console.ReadLine(), out int result);
            while (!state)
            {
                System.Console.Write("Invalid input. Please try again: ");
                state = int.TryParse(System.Console.ReadLine(), out result);
            }

            return result;
        }

    }
}
