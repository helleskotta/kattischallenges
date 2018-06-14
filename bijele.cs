using System;

// https://open.kattis.com/problems/bijele

namespace Bijele
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split(' ');

            var king = Convert.ToInt32(lines[0]); 
            var queen = Convert.ToInt32(lines[1]); 
            var rooks = Convert.ToInt32(lines[2]); 
            var bishops = Convert.ToInt32(lines[3]); 
            var knights = Convert.ToInt32(lines[4]); 
            var pawns = Convert.ToInt32(lines[5]); 

            king = (king == 0) ? 1 : -(king - 1);
            queen = (queen == 0) ? 1 : -(queen - 1);
            rooks = (rooks < 2) ? 2 - rooks : -(rooks - 2);
            bishops = (bishops < 2) ? 2 - bishops : -(bishops - 2);
            knights = (knights < 2) ? 2 - knights : -(knights - 2);
            pawns = (pawns < 8) ? 8 - pawns : -(pawns - 8);

            Console.WriteLine($"{king} {queen} {rooks} {bishops} {knights} {pawns}");
        }
    }
}
