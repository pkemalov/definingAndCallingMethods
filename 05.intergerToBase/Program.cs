using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.intergerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            var result = IntegetToBase(number, toBase);
            Console.WriteLine(result);
        }

        static string IntegetToBase(long ourNumber, int ourBase)
        {
            string finalNumber = string.Empty;

            while (ourNumber>0)
            {
                var startingNumber = ourNumber % ourBase;
                finalNumber = startingNumber + finalNumber;
                ourNumber = ourNumber / ourBase;
            }

            return finalNumber;
        }
    }
}
