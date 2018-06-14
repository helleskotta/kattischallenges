using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// https://open.kattis.com/problems/sellingspatulas
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Failing the second test case

namespace SellingSpatulas
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

                List<int> timestamps = new List<int>();
                List<double> sales = new List<double>();
                int firstTime = 0;
                int lastTime = 0;
                int firstIndex = 0;
                int secondIndex = 0;
                List<Tuple<double, int, int>> all = new List<Tuple<double, int, int>>();

                for (int i = 0; i < cases; i++)
                {
                    string[] line = Console.ReadLine().Split(' ');
                    timestamps.Add(Convert.ToInt32(line[0]));
                    sales.Add(Convert.ToDouble(line[1], CultureInfo.InvariantCulture));
                }
                
                bool exit = false;
                int maxIndex = timestamps.Count - 2;

                while (!exit)
                {
                    double profit = 0;
                    firstTime = timestamps[firstIndex];
                    lastTime = timestamps[secondIndex];

                    profit = sales.GetRange(firstIndex, (secondIndex - firstIndex)).Sum() + sales[secondIndex];

                    double cost = (firstIndex == timestamps[0]) ? lastTime * 0.08 : cost = (lastTime - firstTime + 1) * 0.08;

                    var actualProfit = profit - cost;

                    all.Add(new Tuple<double, int, int>(actualProfit, firstTime, lastTime));
                    
                    if (secondIndex < maxIndex)
                    {
                        secondIndex += 1;
                    }
                    else
                    {
                        ++firstIndex;
                        secondIndex = firstIndex;

                        if (firstIndex >= maxIndex)
                            break;
                    }
                }

                var highestProfit = all.OrderByDescending(a => a.Item1).FirstOrDefault();

                if (highestProfit.Item1 <= 0)
                    Console.WriteLine("no profit");

                else
                    Console.WriteLine($"{highestProfit.Item1} {highestProfit.Item2} {highestProfit.Item3} ");
            }
        }
    }
}
