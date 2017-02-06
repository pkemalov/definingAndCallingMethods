using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.stringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string finalWord = string.Empty;

            for (int i = 0; i < n; i++)
            {

                char letter = char.Parse(Console.ReadLine());
                var encrypted = Encrypt(letter);
                finalWord += encrypted;

            }
            Console.WriteLine(finalWord);
        }

        static string Encrypt(char letter)
        {
            var completeWord = string.Empty;
            var ASCIIString = (int)letter;

            var firstNumber = ASCIIString;

            while (firstNumber>=10)
            {
                firstNumber = firstNumber / 10;
            }

            var firstSymbol = firstNumber;
            
            var secondSymbol = ASCIIString % 10;
            var thirdSymbol = (char)(ASCIIString + secondSymbol);
            var fourthSymbol = (char)(ASCIIString - firstSymbol);
            completeWord = $"{thirdSymbol}{firstSymbol}{secondSymbol}{fourthSymbol}";
            return completeWord.ToString();

        }
    }
}
