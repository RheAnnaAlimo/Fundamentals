using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\n Enter a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("\t\n Enter the number of characters you want in the repeated string: ");
            long n = Convert.ToInt64(Console.ReadLine());

            int lengthOfInputString = s.Length;
            long count = 0;
            for (int i = 0; i < s.Length; i++) //count 'a' in original string
            {
                if (s[i] == 'a')
                    count++;
            }

            count = count * (n / s.Length);
            long remainder = n % s.Length;

            for (int i = 0; i < remainder; i++)
            {
                if (s[i] == 'a')
                    count++;
            }

            Console.WriteLine("There are " + count + " a s");
            Console.ReadKey();
        }
    }
}
