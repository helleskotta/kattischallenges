using System;

// https://open.kattis.com/problems/timeloop

namespace Timeloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
                Console.WriteLine($"{i + 1} Abracadabra");
        }
    }
}
