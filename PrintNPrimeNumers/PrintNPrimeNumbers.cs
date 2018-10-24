using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNPrimeNumers
{
    class PrintNPrimeNumbers
    {
        static void Main(string[] args)
        {
            int i, j, n = 0, n1 = 0;
            Console.WriteLine("\n\t Enter a whole, positive number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\t Prime Numbers are: ");

            for (i = 2; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        n1++;
                    }
                }
                if (n1 == 2)
                    Console.WriteLine("\t"+ i);
                n1 = 0;
            }
            Console.ReadLine();
        }
    }
}

