using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EqualStrings
{
    static void Main(string[] args)
    {
        //Default user input
        string[] input = Console.ReadLine().Split(' ');

        //Trying to use Lists here, but ReSharper suggests using IEnumerable
        //IEnumerable<IGrouping<string, string>> groups = input.GroupBy(name=>name);
        //Using "var" to let the compiler to choose its own array.
        var grouped = input.GroupBy(name => name);

        //simple for-each loop to output the strings
        foreach (var groups in grouped)
        {
            Console.WriteLine(string.Join(" ",groups));
        }

    }
}

