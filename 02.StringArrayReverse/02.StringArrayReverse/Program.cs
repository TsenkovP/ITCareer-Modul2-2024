using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringArrayReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] reversedInput = input.Reverse().ToArray();
            foreach (var item in reversedInput)
            {
                Console.Write($"{item} ");  
            }
            

                
        }
    }
}
