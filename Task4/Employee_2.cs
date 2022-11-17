using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Employee_2
    {
        public Employee_2()
        {
            Console.Write("\nEmployee name: ");
            Name = Console.ReadLine();
            Console.Write("\nEmployee age: ");
            Age = Checks.CheckByte();
        }

        public string? Name { get; set; }
        public uint Salary { get; set; }
        public string? Position { get; set; }
        public string? Company { get; set; }
        public byte age = 18;
        public byte Age
        {
            get { return age; }
            set
            {

                if (value < 18)
                {
                    age = 18;
                    Console.WriteLine("\nAn employee cannot be under 18, so we will set him a minimum age!");
                }
                else
                {
                    age = value;
                }

            }
        }

    }
}

