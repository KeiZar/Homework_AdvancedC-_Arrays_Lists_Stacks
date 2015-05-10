using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArray
{
    static void Main()
    {
        // Reads the user input on one line and removes the spaces in between the numbers.
        string[] input = Console.ReadLine().Split(' '); 

        // Simple Parse from characters to numbers, as long as user input is numbers.
        int[] inputInt = input.Select(int.Parse).ToArray();

        Array.Sort(inputInt); // Using "Array.Sort" class name that is built into System library.

        // Simple output of the array.
        for (int i = 0; i < inputInt.Length; i++)
        {
            Console.Write(inputInt[i] + " ");
        }
        // input -> 6 5 4 10 -3 120 4 || output -> -3 4 4 5 6 10 120
        // input -> 10 9 8 || output -> 8 9 10
    }
}

