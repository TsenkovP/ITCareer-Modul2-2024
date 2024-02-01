using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int[] numbersReversed = numbers
                .Reverse()
                .ToArray();
            for (int i = 0; i < numbersReversed.Length; i++)
            {
                Console.Write($"{numbersReversed[i]} ");
            }

            Console.WriteLine();
        }
    }
}
