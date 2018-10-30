using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    public class SumOfDigits
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SumDigits(37));
        }
        public static int SumDigits(int x)
        {
            int sum = 0;
            while (x!=0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }
    }
}
