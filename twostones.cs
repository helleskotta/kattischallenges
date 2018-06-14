using System;

// https://open.kattis.com/problems/twostones

namespace TwoStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine()) % 2;

            if (input == 0)
                Console.WriteLine("Bob");

            else
                Console.WriteLine("Alice");
        }
    }
}
