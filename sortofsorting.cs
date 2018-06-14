using System;
using System.Collections.Generic;
using System.Linq;

// https://open.kattis.com/problems/sortofsorting

namespace SortOfSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int cases = int.Parse(Console.ReadLine());

                if (cases == 0)
                    break;

                var names = new List<string>();

                for (int i = 0; i < cases; i++)
                    names.Add(Console.ReadLine());
                
                var sortedList = names.OrderBy(n => n.Substring(0, 2), StringComparer.Ordinal);
                
                Console.WriteLine();

                foreach (var name in sortedList)
                    Console.WriteLine(name);
            }
        }
    }
}
