using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    internal class Fish : Unit, ISwim
    {
        public override string Name { get; set; }
        public override string Race { get; set; }
        public override string Sex { get; set; }

        public Fish(string name, string race, string sex)
        {
            Name = name;
            Race = race;
            Sex = sex;
        }

        public void Swiming()
        {
            Console.WriteLine("In which direction do you want to swim??\n[w]; [a]; [s]; [d].");
            Console.WriteLine($"Fish is swim {DirectionMove(Console.ReadLine())}");
        }

        public override void MoveUnit()
        {
            Console.WriteLine("Do you want to start swim on your fish?\n[yes]");

            if (Console.ReadLine().Trim().ToLower() == "yes")
            {
                Swiming();
            }    
            else
            {
                Console.WriteLine("Fish dormant.");
            }
        }
    }
}
