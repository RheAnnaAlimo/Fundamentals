using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            int factorCount = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    factorCount++;
                }  
            }
            Console.WriteLine("Number is not Prime");

            if (factorCount == 1)
            {
                Console.WriteLine("Entered number is Prime");
            }
        }
    }
}
