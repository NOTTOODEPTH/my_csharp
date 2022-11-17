using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class WashingMachine_3 : Appliances_3
    {
        public WashingMachine_3(string maxCapacity, string realCapacity, string washProgr, int timeWash, string name, string color)
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
                return maxCapacity + " cubic meter";
            }
            set
            {
                maxCapacity = value + " cubic meter";
            }
        }
        private string realCapacity;
        public override string RealCapacity
        {
            get
            {
                return realCapacity + " cubic meter";
            }
            set
            {
                realCapacity = value + " cubic meter";
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
                if (!(value == "daily") && !(value == "intensive") && !(value == "semi"))
                {
                    washProgr = "semi";
                }
                else
                {
                    washProgr = value;
                }
            }
        }

        public override string Detergent { get; } = "Washing powder";
        public override string ObjWash { get; } = "Clothing";
        public override int TimeWash { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public override void GoWashDry()
        {
            switch (washProgr)
            {
                case "daily":
                    {
                        Console.WriteLine($"Washing mashine start to daily laundry mode for {TimeWash} minutes");
                        break;
                    }
                case "intensive":
                    {
                        Console.WriteLine($"Washing mashine start to intensive mode for {TimeWash} minutes");
                        break;
                    }
                case "semi":
                    {
                        Console.WriteLine($"Washing mashine start to dry for {TimeWash / 2} minutes");
                        Console.WriteLine($"Washing mashine start to wash for {TimeWash / 2} minutes");
                        break;
                    }
            }

        }

        public override void Start()
        {
            Console.WriteLine("Washing mashine start to work!");
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
            Console.WriteLine("Washing mashine finishing work!");
        }
    }

}
