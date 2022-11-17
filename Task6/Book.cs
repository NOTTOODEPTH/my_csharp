using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less4
{
    class Book : IPrintable
    {
        public Book (string name, string author)
            {
            Name = name;
            Author = author;
            Count++;
            }
        public string Name { get; set; }
        public string Author { get; set; }
        public static int Count { get; set; }

        public void Print()
        {
            Console.WriteLine($"Print method for book");
        }
        static public void PrintBooks (IPrintable[] printable)
        {
            int count = 0;
            Book book;
            Console.WriteLine("PrintBooks method");
            foreach (IPrintable element in printable)
            {
                if (element is Book)
                {
                    book = element as Book;
                    count++;
                    Console.WriteLine($"{count}) {book.Name}, {book.Author}");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
