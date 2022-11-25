using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Class2
    {
        public string String1 { get; set; }
        public string String2 { get; set; }
        public double Double3 { get; }
        public Class2(string String1, string String2)
        {
            String1 = String1;
            String2 = String2;
        }
        public Class2()
        { }
        public void Method1(string String)
        {
            Console.WriteLine("First method");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Second method");
        }
    }
}
