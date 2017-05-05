using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _552017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List out numbers seperated by commas. This program will see if it adds up to zero.");
            string numbers = Console.ReadLine();
            numbers.Replace("\n", string.Empty);
            string[] splitNums = numbers.Split(',');
            int length = splitNums.Length;
            List<int> num = new List<int>();
            int i = 0;
            while (i != length){
                num.Add(Int32.Parse(splitNums[i]));
                i++;
            }
            
            int b = 0;
            int result = 0;
            int listcount = num.Count;
            while(b != listcount)
            {
                result = result + num[b];
                b++;

            }
            if(result == 0)
            {
                Console.WriteLine("Yes, it equals zero.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("sike it doesn't");
                Console.ReadLine();
            }



        }
    }
}
