using System;

// https://open.kattis.com/problems/autori

namespace Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split('-');
            var abreviation = "";

            foreach (var item in lines)
                abreviation += item.Substring(0, 1);
            
            Console.WriteLine(abreviation);
        }
    }
}
