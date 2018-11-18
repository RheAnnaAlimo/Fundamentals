using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(7));
        }
        public static bool IsPrime(int num)
        {
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
            }
        }
    }
