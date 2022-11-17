using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Point_1
    {
        public double X { get; set; }
        public double Y { get; set; }

        static int counter = 0; 
        public static int Counter
        {
            get
            {
               return counter; 
            }
        }
        
        public Point_1()
        {
            counter++;
            static double CheckDouble(char nameDouble)
            {
                string? myString;
                bool check;
                double thisDouble;
                do
                {
                    Console.Write($"For {counter} point enter {nameDouble}: ");
                    myString = Console.ReadLine();
                    check = double.TryParse(myString, out thisDouble);
                    if (!check)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                while (!check);
                return thisDouble;
            }
            X = CheckDouble('x');
            Y = CheckDouble('y');
        }

        public static double LengthPoints(Point_1 point1, Point_1 point2)
        {
            double lenghts;
            lenghts = Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
            return lenghts;
        }

        public static int CheckPoint(int pointsNumber)
        {
            string? myString;
            bool check;
            int thisInt;
            do
            {
                myString = Console.ReadLine();
                check = int.TryParse(myString, out thisInt);
                if ((!check) || (thisInt > pointsNumber) || (thisInt < 1))
                {
                    Console.WriteLine("Invalid input!");
                    check = false;
                }
            }
            while (!check);
            return thisInt - 1;
        }
    }
}
