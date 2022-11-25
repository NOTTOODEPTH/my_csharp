namespace MyClassLibrary
{
    public class Class1
    {
        public int Int1 { get; set; }
        public string String2 { get; set; }
        public Class1(int Int, string String)
        {
            Int1 = Int;
            String2 = String;
        }
        public Class1()
        { }
        private static void Method1()
        {
            Console.WriteLine("First method");
        }
        public string Method2(string String)
        {
            Console.WriteLine($"Second method:\n____________________________\n     This obj has string: {String2}\n     String for method:{String}\n____________________________");
            return $"Return string: {Int1}";
        }
    }
}