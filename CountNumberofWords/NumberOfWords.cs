using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberofWords
{
    class NumberOfWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("Count of words :" + words.Length);
            Console.ReadKey();
        }
    }
}
