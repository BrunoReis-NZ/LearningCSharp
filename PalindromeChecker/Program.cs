using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "A man, a plan, a canal, Panama";
            if (PalindromeChecker(input))
            {
                Console.WriteLine($"The sentence \"{input}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The sentence \"{input}\" is not a palindrome.");
            }

            Console.ReadKey();
        }

        static bool PalindromeChecker(string input)
        {
            string text = FormatText(input);
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reversedText = new string(charArray);
            return text == reversedText;
        }

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

    A man, a plan, a canal, Panama

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