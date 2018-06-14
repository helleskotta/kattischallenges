using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;

// https://open.kattis.com/problems/alldifferentdirections

namespace AllDifferentDirections
{
    class Program
    {
        const string walk = "walk";
        const string turn = "turn";
        static void Main(string[] args)
        {
            while (true)
            {
                int cases = int.Parse(Console.ReadLine());

                if (cases == 0)
                    break;

                List<double[,]> destinations = new List<double[,]>();
                double averageX = 0, averageY = 0;

                for (int i = 0; i < cases; i++)
                {
                    string[] line = Console.ReadLine().Split(' ');
                    var x = Convert.ToDouble(line[0], CultureInfo.InvariantCulture);
                    var y = Convert.ToDouble(line[1], CultureInfo.InvariantCulture);
                    var angle = Convert.ToDouble(line[3], CultureInfo.InvariantCulture);
                    var instruction = "";

                    for (int j = 4; j < line.Length; j++)
                    {
                        if (j % 2 == 0)
                            instruction = line[j];

                        else
                        {
                            if (instruction == walk)
                            {
                                double distance = Convert.ToDouble(line[j], CultureInfo.InvariantCulture);
                                x += Math.Cos(Math.PI * angle / 180.0) * distance;
                                y += Math.Sin(Math.PI * angle / 180.0) * distance;
                            }
                            else if (instruction == turn)
                            {
                                angle += Convert.ToDouble(line[j], CultureInfo.InvariantCulture) % 360;
                            }
                        }
                    }
                    destinations.Add(new double[,] { { x, y } });
                }

                double xCords = 0, yCords = 0;

                foreach (var coordinate in destinations)
                {
                    xCords += coordinate[0, 0];
                    yCords += coordinate[0, 1];
                }

                averageX = xCords / cases;
                averageY = yCords / cases;

                double worstDirection = 0;
                foreach (var coordinate in destinations)
                {
                    double xCord = coordinate[0, 0];
                    double yCord = coordinate[0, 1];

                    double distance = Math.Sqrt((averageX - xCord) * (averageX - xCord) + (averageY - yCord) * (averageY - yCord));

                    if (distance > worstDirection)
                        worstDirection = distance;
                }
                Console.WriteLine($"{averageX} {averageY} {worstDirection}");
            }
        }
    }
} 
