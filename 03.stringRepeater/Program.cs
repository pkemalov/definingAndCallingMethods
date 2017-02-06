using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.stringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string finalString = RepeatString(input, n);
            Console.WriteLine(finalString);
        }

        static string RepeatString(string word, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString = repeatedString + word;
            }
            return repeatedString;
        }
    }
}
