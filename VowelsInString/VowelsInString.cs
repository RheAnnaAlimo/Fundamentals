using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsInString
{
    class VowelsInString
    {
        static void Main(string[] args)
        {
            int total = 0;

            Console.WriteLine("Enter a Sentence");
            string sentence = Console.ReadLine().ToLower();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || 
                    sentence[i] == 'e' || 
                    sentence[i] == 'i' || 
                    sentence[i] == 'o' || 
                    sentence[i] == 'u')
                {
                    total++;
                }
            }
            Console.WriteLine("Your total number of vowels is: {0}", total);
            Console.ReadLine();
        }
    }
}
    