using System;

// https://open.kattis.com/problems/r2

namespace R2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            var r1 = Convert.ToInt32(line[0]);
            var s = Convert.ToInt32(line[1]);
            var r2 = s * 2 - r1;
            Console.WriteLine(r2);
        }
    }
}
