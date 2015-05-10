using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SelectionSort
{
    static void Main()
    {
        // Same input and output lines as Problem 1: Sort Array of Numbers
        string[] input = Console.ReadLine().Split(' ');
        int[] inputInt = input.Select(int.Parse).ToArray();

        // Setting up integers for sorting help later in a for loop.
        int lowest, newIndex;

        //a for loop that uses the amount of elements in the array, and checks each number with
        //each other and sorts them from min and max.
        for (int i = 0; i < inputInt.Length - 1;i++)
        {
            lowest = i;
            for (int j = i + 1; j < inputInt.Length; j++)
            {
                if (inputInt[j] < inputInt[lowest])
                {
                    lowest = j;
                }
            }
            newIndex = inputInt[i];
            inputInt[i] = inputInt[lowest];
            inputInt[lowest] = newIndex;

        }

        // Output of the sorted array || same input as Problem 1.
        for (int i = 0; i < inputInt.Length; i++)
        {
            Console.Write(inputInt[i] + " ");
        }

    }
}
