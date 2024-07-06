using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            TextFormatter(sentence);
        }

        static void TextFormatter(string text)
        {
            string upper = text.ToUpper();
            string replace = text.Replace(' ', '_');
            int indexOf = text.IndexOf('a');
            string substring = text.Substring(4, 6);
            string[] splits = text.Split(' ');
            string join = string.Join('-', splits);

            Console.WriteLine("Sentence: " + text);
            Console.WriteLine("Uppercase: " + upper);
            Console.WriteLine("Replace spaces with underscores: " + replace);
            Console.WriteLine("Position of first 'a': " + indexOf);
            Console.WriteLine("Substring (5th to 10th character): " + substring);
            Console.WriteLine("Split and join with hyphens: " + join);
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

    Uppercase: THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG
    Replace spaces with underscores: THE_QUICK_BROWN_FOX_JUMPS_OVER_THE_LAZY_DOG
    Position of first 'A': 33
    Substring (5th to 10th character): QUICK 
    Split and join with hyphens: THE-QUICK-BROWN-FOX-JUMPS-OVER-THE-LAZY-DOG
*/