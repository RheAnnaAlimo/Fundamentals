using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnInteger
{
    class ReverseInteger
    {
        public static long mirror (int value)
        {
            long sum = 0;
            for (int i = value; i!=0; i=i/10)
            {
                int remainder = i % 10;
                sum = sum * 10 + remainder;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine($"{X} --> {mirror(X)}");
        }
    }
}
