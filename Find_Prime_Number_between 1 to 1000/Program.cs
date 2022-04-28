using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Prime_Number_between_1_to_1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the program for find PrimeNumbers between 1 to 200");
            bool isPrime = true;
            int i;
            int j;
            // using for loop to find the prime number
            for (i = 2; i <=200; i++)
            {
                for (j = 2; j <=200; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}
