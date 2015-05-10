using System;
using System.Collections.Generic;
using System.Linq;

    class SortingMinMax
    {
        static void Main()
        {
            //Simple user input
            string input = Console.ReadLine();

            //Parse numbers into an array
            double[] inputNumbers = input.Split(' ').Select(double.Parse).ToArray();

            //Define Lists for round numbers and decimals
            List<double> roundNumber = new List<double>();
            List<double> floatingNumbers = new List<double>();

            //for loop to check and sort every input number to a proper list.
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] % 1 != 0)
                {
                    floatingNumbers.Add(inputNumbers[i]);
                }
                else
                {
                    roundNumber.Add(inputNumbers[i]);
                }
            }

            //Output of the arrays, sorted with min, max, sum and avg of the numbers.
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", floatingNumbers), floatingNumbers.Min(), floatingNumbers.Max(), floatingNumbers.Sum(), floatingNumbers.Average());
            Console.WriteLine();
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", roundNumber), roundNumber.Min(), roundNumber.Max(), roundNumber.Sum(), roundNumber.Average());
        }
    }   

