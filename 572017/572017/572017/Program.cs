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
            Console.WriteLine("Please state the words that are embedded.");
            string words = Console.ReadLine();
            words = words.Replace(" ", String.Empty);
            Console.WriteLine(words);
            Console.ReadLine();
        }
    }
}
