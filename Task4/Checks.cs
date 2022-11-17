using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
     class Checks
    {
         public static string StrCheck()
        {
            string? str;
            do
            {
                str = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(str))
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            while (string.IsNullOrWhiteSpace(str));
            return str;

        }

        public static uint CheckUint()
        {
            string? myString;
            bool check;
            uint thisUint;
            do
            {
                myString = Console.ReadLine();
                check = uint.TryParse(myString, out thisUint);
                if (!check)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            while (!check);
            return thisUint;
        }

        public static byte CheckByte()
        {
            string? myString;
            bool check;
            byte thisByte;
            do
            {
                myString = Console.ReadLine();
                check = byte.TryParse(myString, out thisByte);
                if (!check)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            while (!check);
            return thisByte;
        }
    }
}
