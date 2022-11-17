using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    abstract class Unit
    {
        public abstract string Name { get; set; }
        public abstract string Race { get; set; }
        public abstract string Sex { get; set; }

        public string DirectionMove(string choseDirection)
        {
            
            switch (choseDirection.Trim().ToLower())
            {
                case "w":
                    return "forward";
                case "s":
                    return "backward";
                case "a":
                    return "left";
                case "d":
                    return "right";
                default:
                    return "still";
            }
        }

        public abstract void MoveUnit();

    }
}
