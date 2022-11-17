using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less4
{
    public static class Checks
    {
        static public int CheckPrice(int value, int price, string model, int limit, string name)
        {
            string? myString;
            bool check = true;
            if (value < limit)
            {
                while ((price < limit) || (!check))
                {
                    Console.WriteLine($"This price is too small for model {model} {name}! Try another.");
                    myString = Console.ReadLine();
                    check = int.TryParse(myString, out price);
                    if (!check)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
            }
            else
            {
                price = value;
            }
            return price;
        }
    }
}
