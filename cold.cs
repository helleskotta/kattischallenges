using System;

// https://open.kattis.com/problems/cold

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            Console.ReadLine();

            string[] lines = Console.ReadLine().Split(' ');

            foreach (var item in lines)
                if (Convert.ToInt32(item) < 0)
                    counter += 1;
            
            Console.WriteLine(counter);
        }
    }
}
