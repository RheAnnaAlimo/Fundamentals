using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySumEvens
{
    class SumofEvens
    {
        //Given an interger Array, total all of the even numbers.
        static void Main(string[] args)
        {
        //    int[] intArray = { 2, 3, 5, 6, 10 };
        //    Console.WriteLine(intArray.Where(i => i % 2 == 0).Sum(i => (long)i));
        }

        public static void SumTheEvens()
        {
            int x = 0;
            int result=0;
            for (int i = 0; i <= 12; i++)
            {
                if (x % 2 == 0)
                {
                    x += result;
                }
            }
            
        }
    }
}
