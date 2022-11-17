using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less4
{
    class Guitar : IMusic
    {
        public Guitar(string model, string сharacteristics, int price)
        {
            Model = model;
            Сharacteristics = сharacteristics;
            Price = price;
            Count++;
        }

        public int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = Checks.CheckPrice(value, price, Model, 100, "guitar");
            }
        }
        public string Model { get; set; }
        public static int Count { get; set; }
        public string Сharacteristics { get; set; }

        public void PlaySound()
        {
            Console.WriteLine($"Playing a model {Model} of guitar with this characteristics: {Сharacteristics}; Price = {price} $ ");
        }
    }
}
