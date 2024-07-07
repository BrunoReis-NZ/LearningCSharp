using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence: \n");
            string sentence = Console.ReadLine();
            TextFormatter(sentence);
            Console.ReadKey();
        }

        /// <summary>
        ///  This method uses string methods to format the sentence as required
        /// </summary>
        /// <param name="text">The sentence to be formatted</param>
        static void TextFormatter(string text)
        {
            int length = text.Length; 
            string upper = text.ToUpper(); 
            string lower = text.ToLower();
            string substring = text.Substring(4, 6);
            int indexOf = text.IndexOf('a');
            int lastIndexOf = text.LastIndexOf('a');
            bool contains = text.Contains("Hello World");
            bool contains2 = text.Contains("fox");
            string replace = text.Replace(' ', '_');
            string[] splits = text.Split(' ');
            string join = string.Join('-', splits);

            Console.WriteLine($"\nThe length of the sentence is: {length}");
            Console.WriteLine($"The sentence to uppercase: {upper}");
            Console.WriteLine($"The sentence to lowercase: {lower}");
            Console.WriteLine($"Substring (5th to 10th character): {substring}");
            Console.WriteLine($"Position of first 'a': {indexOf} and last 'a': {lastIndexOf}");
            Console.WriteLine($"Contains \"Hello World\": {contains}");
            Console.WriteLine($"Contains \"fox\": {contains2}");
            Console.WriteLine($"Replace spaces with underscores: {replace}");
            Console.WriteLine($"Split and join with hyphens: {join}");
        }
    }
}




/*
Problem: Text Formatter
Topic: String Methods

Write a C# program that takes a sentence from the user and performs the following operations:

Converts the entire sentence to uppercase.
Replaces all spaces with underscores.
Finds the position of the first occurrence of the letter 'A'.
Extracts a substring starting from the 5th character to the 10th character.
Splits the sentence into words based on spaces and joins them with hyphens.
The program should display the results of each operation.

Example

Input:

    The quick brown fox jumps over the lazy dog

Output:

    The length of the sentence is: 43
    The sentence to uppercase: THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG
    The sentence to lowercase: the quick brown fox jumps over the lazy dog
    Substring (5th to 10th character): quick
    Position of first 'a': 36 and last 'a': 36
    Contains "Hello World": False
    Contains "fox": True
    Replace spaces with underscores: The_quick_brown_fox_jumps_over_the_lazy_dog
    Split and join with hyphens: The-quick-brown-fox-jumps-over-the-lazy-dog
*/

    