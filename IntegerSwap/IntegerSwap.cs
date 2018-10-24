using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSwap
{
    public class IntegerSwap //has to be public for unit testing
    {
        public static string IntSwap(int A, int B)
        {
            A = A + B;
            B = A - B;
            A = A - B;
            return ($"{A},{B}");
        }
        public static void Main(string[] args)
        {
            int A = 5;
            int B = 7;
            Console.WriteLine($"{A},{B} <--> " + IntSwap(A,B));
            Console.WriteLine("\n\t IntergerSwap.Main()\n\t....continue...");
            Console.ReadKey();
        }
    }
}
