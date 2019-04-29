using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string response = "y";

            Console.WriteLine("Welcome to the Pig Latin Translator");

            while(response == "y")
            {
                Console.WriteLine("\nEnter a line to be translated: ");
                input = Console.ReadLine().ToLower();

                Console.WriteLine(PigLatin(input));




                Console.WriteLine("Translate another line? (y/n)" );
                response = Console.ReadLine().ToLower();
            }




          


        }

        public static string PigLatin(string word)
        {
            int count = 0;
            // if the word contains any vowels = true
            if (word.Contains('a') || word.Contains('e') || word.Contains('i') || word.Contains('o') || word.Contains('u'))
            {
                // if the first letter of the word has any vowels add the word way
                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')
                {
                    return word + "way";

                }
                else
                {
                    for(int i = 0; i < word.Length; i++)    // scan the entire word. or stop after the last consonant.
                    {
                        // if characters are not vowels keep going until you find a vowel
                        if(word[i] != 'a' && word[i] != 'e' && word[i] != 'i' && word[i] != 'o' && word[i] != 'u')
                        {
                            // records each time loop finds a consonant
                            count++;
                        }
                        // finds vowel and changes string
                        else
                        {
                            // make a new substring from our original string 'word' starting from the first letter to the last recorded consonant
                            string consonants = word.Substring(0, count);
                            string newWord = word.Substring(count, word.Length - count) + consonants + "ay";
                            return newWord;



                        }

                    }
                    return word;


                }




            }
            else
            {
                return word + "ay";
            }

        }

    }
}
