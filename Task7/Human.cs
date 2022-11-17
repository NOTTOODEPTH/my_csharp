using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Human : Unit, ISwim, IJump, IGo
    {
        public override string Name { get; set; }
        public override string Race { get; set; }
        public override string Sex { get; set; }

        public Human(string name, string race, string sex)
        {
            Name = name;
            Race = race;
            Sex = sex;
        }

        public void Swiming()
        {
            Console.WriteLine("In which direction do you want to swim??\n[w]; [a]; [s]; [d].");
            Console.WriteLine($"Human is swim {DirectionMove(Console.ReadLine())}");
        }

        public void Jumping()
        {
            Console.WriteLine("In which direction do you want to jump??\n[w]; [a]; [s]; [d].");
            Console.WriteLine($"Human is jump {DirectionMove(Console.ReadLine())}");
        }
        public void Going()
        {
            Console.WriteLine("In which direction do you want to go??\n[w]; [a]; [s]; [d].");
            Console.WriteLine($"Human is go {DirectionMove(Console.ReadLine())}");
        }

        public override void MoveUnit()
        {
            Console.WriteLine("How is move your human?\n[swim]; [jump]; [go].");
            switch (Console.ReadLine().Trim().ToLower())
            {
                case "swim":
                    Swiming();
                    break;
                case "jump":
                    Jumping();
                    break;
                case "go":
                    Going();
                    break;
                default:
                    Console.WriteLine("Human cant move like this.");
                    break;
            }
        }

        
    }
}
