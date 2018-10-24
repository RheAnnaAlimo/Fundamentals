using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        //Given an array of integers, print the reverse of the arrays
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
            
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.ReadLine();
            }
            //foreach (int a in arr)
            //{
            //    Console.WriteLine(a);
            //}
            //Array.Reverse(arr);
            //Console.WriteLine("Reversed Array : ");
            //foreach (int value in arr)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.ReadLine();
        }
    }

