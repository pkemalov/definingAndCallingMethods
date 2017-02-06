using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.minMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int firstmin = GetMin(firstNumber, secondNumber);
            int final = GetMin(firstmin, thirdNumber);
            Console.WriteLine(final);
        }

        static int GetMin(int a, int b)
        {
            var result = Math.Min(a, b);
            return result;

        }
    }
}
