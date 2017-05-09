using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _572017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please state the words that are embedded - seperate each word with a comma");
            string words = Console.ReadLine();
            words = words.Replace(" ", String.Empty); //removes spaces 
            List<string> split = new List<string>(
                 words.Split(new string[] { "," }, StringSplitOptions.None)); //split the string into a list.
            string alphabet = "";
            int count = 3;
            int max = 0;
            int l = 0;
            int r = 0;
            string combined = "";
            while(r != split.Count){
                combined = combined + split[r]; //combines all the strings for comparison
                r++;
            }
            while (l < split.Count) //finds the length of the biggest string
            {
                if(split[l].Length > max)
                {
                    max = split[l].Length;
                    l++;

                }
                else
                {
                    l++;
                }
            }
            count = max * split.Count;
            alphabet = makeSequence(alphabet, count); //makes a stupid long supersequence

            int combinedLength = combined.Length;
            alphabet = removeRed(alphabet, combined, combinedLength); //removes redundencys
            finalize(alphabet, split);
            
            Console.WriteLine(alphabet);
            Console.ReadLine();
            
            
        }
        public static string finalize(string alphabet, List<string> split)
        {
            bool firstRemoved = false;
            int i = 0;
            int u = 0;
            int p = 0;
            string combinedFirst = "";
            while(u != split.Count)
            {
                string ugh = split[u];   //gets the first letter of every string in the list
                combinedFirst = combinedFirst + ugh[0];
                u++;
            }
            int firstLength = combinedFirst.Length;
            while(firstRemoved == false)
            {
                while(p != firstLength + 1)
                {
                    if(alphabet[i] == combinedFirst[p])
                    {
                        firstRemoved = true;
                    }
                    else
                    {
                        p++;
                    }
                }
                if(p == firstLength + 1)
                {
                    Console.WriteLine("Removed : " + alphabet[i]);
                    alphabet = alphabet.Remove(i);
                    Console.WriteLine("New: " + alphabet[i]);
                    p = 0;
                    
                }
            }
            


            return alphabet;
        }

        public static string removeRed(string alphabet, string combined, int combinedLength)
        {
            int alphabetRed = 0;
            int combinedRed = 0;

            while (alphabetRed != alphabet.Length)
            {
                if(combinedRed != combinedLength)
                {
                    if (alphabet[alphabetRed] == combined[combinedRed])
                    {
                        combinedRed = 0;
                        alphabetRed++;
                        Console.WriteLine("aint shit found");
                    }
                    else 
                    {
                        combinedRed++;

                    }
                }
                else
                {
                    Console.WriteLine("Found!" + alphabet[alphabetRed]);
                    alphabet = alphabet.Replace(alphabet[alphabetRed].ToString(), String.Empty);
                    combinedRed = 0;
                    
                }
            }
            return alphabet;
        }
        public static string makeSequence(string alphabet, int count)
        {
            int i = 0;
            while (i != count)
            {
                alphabet = alphabet + "abcdefghijklmnopqrstuvwxyz";  
                i++;
            }
            return alphabet;
        }

    }
}
