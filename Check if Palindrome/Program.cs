using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_Palindrome
{
    public static class Constants
    {
        public const int characterArraySize = 255;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Let's print out a nice welcome message for our user.
            Console.WriteLine("Welcome to Josh's Palindrome Checker 5000!\n");

            // Ask the user for the string they would like reversed.
            Console.Write("Please enter the word/phrase/number you would like checked (max length: {0} characters): ", Constants.characterArraySize);

            // Read the user input and store it in a variable.
            string originalString = Console.ReadLine();
            Console.Write("\n");

            // Remove all spaces from originalString and store it in a string variable called processedString.
            string processedString = originalString.Replace(" ", string.Empty);
            processedString = processedString.ToLower();
            int characterNumber = processedString.Length;

            // Store the processedString characters in an array called characterArray.
            char[] characterArray = new char[Constants.characterArraySize];

            int loopCounter = 0;

            foreach (char c in processedString)
            {
                characterArray[loopCounter] = c;

                loopCounter++;
            }

            // Run through the array backwards to make a string variable called reversedString.
            string reversedString = "";

            for (int loopCount = characterNumber - 1; loopCount >=0; loopCount--)
            {
                reversedString = reversedString + characterArray[loopCount];
            }

            // Compare reversedString to processedString.
            Boolean isPalindrome = false;
            if (processedString == reversedString)
            {
                isPalindrome = true;
            }

            Console.WriteLine(originalString);
            Console.WriteLine(processedString);
            Console.WriteLine(reversedString);

            // Output the result of the test to the user.
            if (isPalindrome == true)
            {
                Console.WriteLine("Congratulations, this IS a palindrome!");
            }
            else Console.WriteLine("Sorry, this is NOT a palindrome.");

            // Pause the console so the user can read the information
            Console.WriteLine("\nThanks for using my program. Please press the Enter key to exit! :)");
            Console.ReadLine();
        }
    }
}
