using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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

        public static void StringSeperatorReverse_4()
        {
            Console.Write("Input a string: ");
            string userInput = Console.ReadLine();

            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);

            foreach (char charArrays in charArray)
            {
                Console.Write(charArrays + " ");
            }
        }

        public static void StringWordCounter_5()
        {
            Console.Write("Input a string text: ");
            string userInput = Console.ReadLine();

            //split string into array of words
            string[] words = userInput.Split(' ');

            int numberOfWords = words.Length;
            Console.Write($"Total number of words in string is: {numberOfWords}");
        }

        public static void StringCompare_6()
        {
            Console.Write("Input the 1st string: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Input the 2nd string: ");
            string userInput2 = Console.ReadLine();
            Console.WriteLine();

            if (userInput1 == userInput2)
            {
                Console.WriteLine("The length of both strings are equal and also, both strings are equal.");
            }
            else if (userInput1 !=userInput2)
            {
                Console.WriteLine("The length of both string are not equal and also, both strings are not equal.");
            }
        }

        public static void StringCopy_8()
        {
            //string string1 = "This is the first string";
            //string string2 = String.Copy(string1);

            //Console.WriteLine(string2);
        }

        public static void VowelAndConsonantCounter_9()
        {
            Console.Write("Input a string to check the amount of vowels or consonant: ");
            string userInput = Console.ReadLine();

            int vowelsCounter = 0;
            int consonantCounter = 0;
            foreach (var checker in userInput)
            {
                if (checker == 'a' || checker == 'e' || checker == 'i' || checker == 'u')
                {
                    vowelsCounter++;
                }
                else
                {
                    //removing white spaces
                    if (checker == ' ')
                    {
                        consonantCounter--;
                    }
                    consonantCounter++;
                }
            }
            Console.WriteLine($"The total amount of vowels in the string is: {vowelsCounter}");
            Console.WriteLine($"The total amount of consonant in the string is: {consonantCounter}");
        }

        public static void FindMaxChar_10()
        {
            int[] ch_fre = new int[255];
            int i = 0, max, l;
            int ascii;

            Console.Write("Input a string to find maximun occuring character: ");
            string userInput = Console.ReadLine();

            l = userInput.Length;

            for (i = 0; i < 255; i++)
            {
                ch_fre[i] = 0;
            }

            i = 0;
            while (i < l)
            {
                ascii = (int)userInput[i];
                ch_fre[ascii] += 1;

                i++;
            }

            max = 0;
            for (i = 0; i < 255; i++)
            {   
                if (i != 32)
                {
                    if (ch_fre[i] > ch_fre[max])
                        max = i;
                }
            }
            Console.Write("The Highest frequency of character '{0}' is appearing for number of times : {1} \n\n", (char)max, ch_fre[max]);
        }

        public static void ArraySorterAsc_11()
        {
            Console.Write("Input a string to sort the characters by ascending order: ");
            string userInput = Console.ReadLine();

            char[] charArray = userInput.ToCharArray();

            char[] sortedArray = charArray.OrderBy(i => i).ToArray();

            sortedArray = sortedArray.Where(x => !Char.IsWhiteSpace(x)).ToArray();

            foreach (char chars in sortedArray)
            {
                Console.Write(chars + " ");
            }
        }
         public static void ArrayBubbleSorter_12()
         {
            Console.Write("Input number of strings: ");
            int numOfStrings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"input {numOfStrings} strings below");
            string[] stringArray = new string[numOfStrings];
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write($"string {i +1}: ");
                stringArray[i] = Console.ReadLine();
            }

            string[] sortedString = stringArray.OrderBy(s => s).ToArray();

            Console.WriteLine();
            Console.WriteLine("After sorting the array appears like: ");
            foreach(var elements in sortedString)
            {
                Console.WriteLine(elements);
            }
         }

        public static void SubStringFinder_13()
        {
            string str;
            char[] arr1;
            int pos, l, ln, c = 0;

            Console.Write("\n\nExtract a substring from a given string:\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Input the string : ");
            str = Console.ReadLine();
            ln = str.Length;
            arr1 = str.ToCharArray(0, ln);

            Console.Write("Input the position to start extraction :");
            pos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the length of substring :");
            l = Convert.ToInt32(Console.ReadLine());

            Console.Write("The substring retrieve from the string is : ");
            while (c < l)
            {
                Console.Write(arr1[pos + c - 1]);
                c++;
            }
            Console.Write("\n\n");
        }

        public static void SubStringChecker_14()
        {
            Console.Write("Input the string: ");
            string userInput = Console.ReadLine();

            Console.Write("Input the substring: ");
            string subString = Console.ReadLine();

            if (userInput.Contains(subString))
            {
                Console.WriteLine("The substring exists in the string");
            }
           else
            {
                Console.WriteLine("The substring does not exists in the string");
            }
        }

        public static void StringLowUpConverter_15()
        {
            Console.Write("Input the string: ");
            var userInput = Console.ReadLine();
            var charArray = userInput.ToCharArray();

            foreach (var elements in charArray)
            {
                if (Char.IsUpper(elements))
                {
                    Console.Write(Char.ToLower(elements));
                }
                else
                {
                    Console.Write(Char.ToUpper(elements));
                }
            }
        }

        static void Main(string[] args)
        {
            StringLowUpConverter_15();
        }
    }
}
