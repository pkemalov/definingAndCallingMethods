using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.nthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int result = FindNthDigit(number, index);
            Console.WriteLine(result);
        }

        static int FindNthDigit(long definedNumber, int digitToFind)
        {
            int currentIndex = 1;

            while (definedNumber>0)
            {
                if (digitToFind==currentIndex)
                {
                    int ourResult = (int)(definedNumber % 10);
                    return ourResult;
                }

                definedNumber = definedNumber / 10;
                currentIndex += 1;
            }
            return (int)(definedNumber % 10);
        }
    }
}
