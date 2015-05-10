using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Longest_Increasing_Sequence
{
    class LongestincreasingSequence
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int[] inputNumbers = input.Split().Select(int.Parse).ToArray();

            int counter = 1;
            int maxLengt = 1;
            int end = 0;

            Console.Write(inputNumbers[0] + " ");
            for (int i = 1; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] > inputNumbers[i - 1])
                {
                    counter++;
                    Console.Write(inputNumbers[i] + " ");
                }
                else
                {
                    counter = 1;
                    Console.WriteLine();
                    Console.Write(inputNumbers[i] + " ");
                }
                if (counter > maxLengt)
                {
                    maxLengt = counter;
                    end = i;
                }
            }
            Console.WriteLine();
            Console.Write("Longest: ");
            for (int i = end - maxLengt + 1; i <= end; i++)
            {
                Console.Write(inputNumbers[i]+" ");
            }

        }
    }
}
