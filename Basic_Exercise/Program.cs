using System;

namespace Basic_Exercise
{
    class Program
    {
        /*----------w3resource String exercise-------------*/

        public static void StringInput_1()
        {
            Console.Write("Input a string: ");
            string userInput = Console.ReadLine();

            Console.WriteLine($"The string you entered is: {userInput}");
        }

        public static void StringCounter_2()
        {
            Console.Write("Input a string: ");
            string userInput = Console.ReadLine();

            int stringCounter = 0;
            foreach (char charArray in userInput)
            {
                stringCounter++;
            }

            Console.WriteLine($"Length of the string is: {stringCounter}");
        }

        public static void StringSeperator_3()
        {
            Console.Write("Input a string: ");
            string userInput = Console.ReadLine();

            foreach (char charArray in userInput)
            {
                Console.Write(charArray + " ");
            }
        }



        static void Main(string[] args)
        {
            StringSeperator_3();
        }
    }
}
