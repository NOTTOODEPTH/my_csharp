using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Bird : Unit, IFly, IJump
    {
        public override string Name { get; set; }
        public override string Race { get; set; }
        public override string Sex { get; set; }

        public Bird (string name, string race, string sex)
        {
            Name = name;
            Race = race;
            Sex = sex;
        }

        public void Flying()
        {
            Console.WriteLine("In which direction do you want to fly??\n[w]; [a]; [s]; [d].");
            Console.WriteLine($"Bird is fly {DirectionMove(Console.ReadLine())}");
        }

        public void Jumping()
        {
            Console.WriteLine("In which direction do you want to jump??\n[w]; [a]; [s]; [d].");
            Console.WriteLine($"Bird is Jump {DirectionMove(Console.ReadLine())}");
        }

        public override void MoveUnit()
        {
            Console.WriteLine("How is move your bird?\n[fly]; [jump].");
            switch (Console.ReadLine().Trim().ToLower())
            {
                case "fly":
                    Flying();
                    break;
                case "jump":
                    Jumping();
                    break;
                default:
                    Console.WriteLine("Bird cant move like this.");
                    break;
            }
        }
    }
}
