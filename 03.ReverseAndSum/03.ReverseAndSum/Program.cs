using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReverseAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = input
                .Select(int.Parse)
                .ToArray();
            int rotationTimes = int.Parse(Console.ReadLine());
            int[] sumArray = new int[numbers.Length];
            int[] reversedArray = numbers;
            for (int i = 0; i < rotationTimes; i++)
            {
                int oldNumber = numbers[numbers.Length-1];
                
                for (int j = numbers.Length - 1; j > 0; j--)
                {

                    reversedArray[j] = reversedArray[j-1];
                    if (j == 1)
                    {
                        reversedArray[0] = oldNumber;
                    }
                }

                for (int k = 0; k < numbers.Length; k++)
                {
                    sumArray[k] = sumArray[k] + reversedArray[k];
                    
                }

            }
            foreach (var element in sumArray)
            {
                Console.Write($"{element} ");
            }

        }
    }
}
