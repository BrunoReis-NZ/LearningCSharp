using System;

namespace LearningCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine(vowelsCountAndconsonantsCountCounter(sentence));
            Console.ReadKey();
        }

        /// <summary>
        /// This method counts the number of vowels and consonants in a given string
        /// </summary>
        /// <param name="text">The string to be analyzed</param>
        /// <returns>A string containing the counts of vowels and consonants</returns>
        public static string vowelsCountAndconsonantsCountCounter(string text)
        {
            int vowelsCount = 0;
            int consonantsCount = 0;

            string sentence = FormatText(text);

            for (int i = 0; i < sentence.Length; i++) {

                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    vowelsCount++;
                }
                else
                {
                    consonantsCount++;
                }
            }

            return $"The sentence contains {vowelsCount} vowels and {consonantsCount} consonants.";


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
Problem: Vowels and Consonants Counter
Topic: String Methods, 

Write a C# program that counts the number of vowels (A, E, I, O, U) and consonants in a given string. 
The program should be case-insensitive and should ignore non-letter characters.

Requirements:

    1. The program should ignore case.
    2. It should count only letters as consonants.
    3. Non-letter characters (spaces, punctuation, digits, etc.) should be ignored.

Example:

Input:

    "Hello, World!"

Output:

    The sentence contains 3 vowels and 7 consonants.

Input:

    Hello, World!

Output:

False

Instructions:
    1. Input Handling: Prompt the user to enter a sentence.
    2. Text Normalization: Convert the input string to lowercase.
    3. Character Filtering: Remove all non-letter characters.
    4. Vowel Counting: Count the number of vowels in the filtered string.
    5. Consonant Counting: Count the number of consonants in the filtered string.
    Output: Print the counts of vowels and consonants.
*/