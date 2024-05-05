
using System;

namespace StringLengthFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define an initial string array
            string[] inputArray = new[] { “Russia”, “Denmark”, “Kazan” };

            // Filter the array by length
            string[] filteredArray = FilterByLength(inputArray, 3);

            // Print the results to the console
            foreach (string s in filteredArray)
            {
                Console.WriteLine(s);
            }
        }

        static string[] FilterByLength(string[] inputArray, int maxLength)
        {
            int count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= maxLength)
                {
                    count++;
                }
            }
            string[] outputArray = new string[count];
            int index = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length <= maxLength)
                {
                    outputArray[index] = inputArray[i];
                    index++;
                }
            }
            return outputArray;
        }
    }
}

