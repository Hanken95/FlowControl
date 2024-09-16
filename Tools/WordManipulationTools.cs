using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class WordManipulationTools
    {
        //Splits the word by the selected separator
        private static string[] SplitWord(string wordToSplit, char separator)
        {
            return wordToSplit.Split(separator);
        }

        //Takes an input, makes sure it is correctly entered and returns the third word
        public static string ReturnTheThirdWord()
        {
            Console.Clear();
            string[] words;

            Console.WriteLine("Enter a sentence  with at least 3 words that are separated by spaces");
            words = SplitWord(Console.ReadLine(), ' ');

            if (words.Length < 3)
            {
                Console.Clear();
                Console.WriteLine("Wrong input. There needs to be at least 3 words and they all have to be separated by spaces");
                Console.WriteLine("Press any key to try again");
                Console.ReadKey(true);
                Console.Clear();
                return ReturnTheThirdWord();
            }
            else
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(words[i]))
                    {
                        Console.WriteLine("\nWrong input, there can only be one space between words and the words cannot be just spaces " +
                            "\nThere can also not be any spaces before the first and after the last word");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey(true);
                        Console.Clear();
                        return ReturnTheThirdWord();
                    }
                }
                Console.Clear();
            }
            
            return words[2];
        }
    }
}
