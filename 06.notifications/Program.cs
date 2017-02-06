using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();

                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }

                else if (result == "error")
                {
                    string anotherOperation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(anotherOperation, code);

                }
            }
        }

        static void ShowError(string anotherOperation, int code)
        {
            if (code >= 0)
            {
                Console.WriteLine($"Error: Failed to execute {anotherOperation}.");
                Console.WriteLine("==============================");
                Console.WriteLine($"Error Code: {code}.");
                Console.WriteLine("Reason: Invalid Client Data.");
            }

            else 
            {
                Console.WriteLine($"Error: Failed to execute {anotherOperation}.");
                Console.WriteLine("==============================");
                Console.WriteLine($"Error Code: {code}.");
                Console.WriteLine("Reason: Internal System Failure.");
            }
        }

        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");

        }
    }
}
