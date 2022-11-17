using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{ 
    public abstract class Appliances_3
    {
        public abstract void Start();

        public abstract void Stop();
        
        public abstract void GoWashDry();

        public static bool loadAppliance(string MaxCapacity, string RealCapacity)
        {
            string onlyNumbMax = "";
            string onlyNumbReal = "";
            for (int i = 0; i < MaxCapacity.Length; i++)
            {
                if (Char.IsDigit(MaxCapacity[i]))
                    onlyNumbMax += MaxCapacity[i];
            }
            for (int i = 0; i < RealCapacity.Length; i++)
            {
                if (Char.IsDigit(RealCapacity[i]))
                    onlyNumbReal += RealCapacity[i];
            }
            bool check;
            int maxInt;
            int realInt;
            do
            {
                check = int.TryParse(onlyNumbMax, out maxInt);
                if ((!check) || (maxInt <= 0))
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            while (!check);
            do
            {
                check = int.TryParse(onlyNumbReal, out realInt);
                if ((!check) || (realInt <= 0))
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            while (!check);
            return realInt >= maxInt;
        }

        public abstract string MaxCapacity { get; set; }
        public abstract string RealCapacity { get; set; }
        public abstract string WashProgr { get; set; }
        public abstract string Detergent { get; }
        public abstract string ObjWash { get; }
        public abstract int TimeWash { get; set; }
    }
    
}
