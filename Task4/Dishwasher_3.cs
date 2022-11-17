using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Dishwasher_3 : Appliances_3
    {
        public Dishwasher_3(string maxCapacity, string realCapacity, string washProgr, int timeWash, string name, string color)
        {
            do
            {
                MaxCapacity = maxCapacity;
                RealCapacity = realCapacity;
            }
            while (loadAppliance(MaxCapacity, RealCapacity));
            WashProgr = washProgr;
            TimeWash = timeWash;
            Name = name;
            Color = color;
        }

        private string maxCapacity;
        public override string MaxCapacity
        {
            get
            {
                return maxCapacity + " plate";
            }
            set
            {
                maxCapacity = value + " plate";
            }
        }
        private string realCapacity;
        public override string RealCapacity
        {
            get
            {
                return realCapacity + " plate";
            }
            set
            {
                realCapacity = value + " plate";
            }
        }
        private string washProgr;
        public override string WashProgr
        {
            get
            {
                return washProgr;
            }
            set
            {
                value = value.Trim();
                value = value.ToLower();
                if (!(value == "dry") && !(value == "wash") && !(value == "semi"))
                {
                    washProgr = "Semi";
                }
                else
                {
                    washProgr = value;
                }
            }
        }

        public override string Detergent { get; } = "Dishwashing liquid";
        public override string ObjWash { get; } = "Tableware";
        public override int TimeWash { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public override void GoWashDry()
        {
            switch (washProgr)
            {
                case "dry":
                    {
                        Console.WriteLine($"Dishwasher start to dry for {TimeWash} minutes");
                        break;
                    }
                case "wash":
                    {
                        Console.WriteLine($"Dishwasher start to wash for {TimeWash} minutes");
                        break;
                    }
                case "semi":
                    {
                        Console.WriteLine($"Dishwasher start to dry for {TimeWash / 2} minutes");
                        Console.WriteLine($"Dishwasher start to wash for {TimeWash / 2} minutes");
                        break;
                    }
            }

        }

        public override void Start()
        {
            Console.WriteLine("Dishwasher start to work!");
            Console.Write("Wait pls");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".\n");
        }

        public override void Stop()
        {
            Console.WriteLine("Dishwasher finishing work!");
        }

    }
}