using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less4
{
    class Magazine : IPrintable
    {
        public Magazine(string name, string publisher)
        {
            Name = name;
            Publisher = publisher;
            Count++;
        }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public static int Count { get; set; }

        public void Print()
        {
            Console.WriteLine("Print method for magazine");
        }
        static public void PrintMagazine(IPrintable[] printable)
        {
            int count = 0;
            Magazine magazine;
            Console.WriteLine("PrintMagazine method");
            foreach (IPrintable element in printable)
            {
                if (element is Magazine)
                {
                    magazine = element as Magazine;
                    count++;
                    Console.WriteLine($"{count}) {magazine.Name}, {magazine.Publisher}");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
