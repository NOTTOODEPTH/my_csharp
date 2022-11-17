﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less4
{
    class Piano : IMusic
    {
        public Piano(string model, string сharacteristics, int price)
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
                price = Checks.CheckPrice(value, price, Model, 500, "piano");
            }
        }
        public string Model { get; set; }
        public static int Count { get; set; }
        public string Сharacteristics { get; set; }

        public void PlaySound()
        {
            Console.WriteLine($"Playing a model {Model} of piano with this characteristics: {Сharacteristics}; Price = {price} $ ");
        }
    }
}
