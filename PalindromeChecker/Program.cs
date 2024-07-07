using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence: \n");
            string sentence = Console.ReadLine();
                        

            if (PalindromeChecker(sentence))
            {
                Console.WriteLine($"\nThe sentence \"{sentence}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\nThe sentence \"{sentence}\" is not a palindrome.");
            }

            Console.ReadKey();
        }


        /// <summary>
        /// This method checks if a given string is a palindrome
        /// </summary>
        /// <param name="input">The string to be checked</param>
        /// <returns>True if the string is a palindrome, false otherwise</returns>
        static bool PalindromeChecker(string input)
        {
            string text = FormatText(input);
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reversedText = new string(charArray);
            return text == reversedText;
        }

        /// <summary>
        /// This method formats the input string by removing non-alphanumeric characters and converting it to lowercase
        /// </summary>
        /// param name="text">The string to be formatted</param>
        /// <returns>The formatted string</returns>
        static string FormatText(string text)
        {
            // Remove non-alphanumeric characters
            char[] arr = text.ToCharArray();
            string result = string.Empty;
            foreach (char c in arr)
            {
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
            }
            // Convert to lowercase
            return result.ToLower();
        }
    }
}



/*
Problem: Palindrome Checker
Topic: String Methods, 

Write a C# program that checks if a given string is a palindrome. 
A palindrome is a word, phrase, number, or other sequences of characters that reads the same forward and backward 
(ignoring spaces, punctuation, and capitalization).

Requirements:
The program should ignore spaces, punctuation, and capitalization.
It should return true if the input string is a palindrome and false otherwise.

Example:
Input:

    "A man, a plan, a canal, Panama!"

Output:

    True

Input:

    Hello, World!

Output:

False

Instructions:
Normalize the input string by removing non-alphanumeric characters and converting it to lowercase.
Check if the normalized string reads the same forwards and backwards.
Return and print true or false.
*/