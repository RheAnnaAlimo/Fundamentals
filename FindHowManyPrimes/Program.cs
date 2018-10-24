using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHowManyPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool isPrime(int number)
        {

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
