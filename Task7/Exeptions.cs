using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class MyException: Exception
    {
        public MyException(string message) : base(message)
        { }
    }

    class MyClass
    {
        public string String { get; set; }
        public MyClass (string str)
        {

            try
            {
                if (str == null)
                {
                    throw new MyException("Your string is null.");
                }
            }
            catch (MyException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                str = "Null string.";
            }
            String = str;
        }
    }
}
