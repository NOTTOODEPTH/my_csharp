using System;
using System.Text.RegularExpressions;
namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //First task

            Console.WriteLine("First task");
            int[] firstMass = new int[6];
            for (int i = 0; i < firstMass.Length; i++)
            {
                firstMass[i] = checkInt(i);
            }

            int checkInt(int i)
            {
                string? myString;
                bool check;
                int thisInt;
                do
                {
                    Console.Write($"Enter the number for {i + 1} element: ");
                    myString = Console.ReadLine();
                    check = int.TryParse(myString, out thisInt);
                    if (!check)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                while (!check);
                return thisInt;
            }
            Array.Sort(firstMass);
            Array.Reverse(firstMass);
            Console.WriteLine("Sort reverse array: [{0}]", string.Join(", ", firstMass));

            //Second task

            Console.WriteLine("\nSecond task");
            int[,] secondMass = new int[3, 3] { { 222, 11, 66 }, { 33, 588, -3000 }, { 1, 2, 3 } };

            int rows = secondMass.GetUpperBound(0) + 1;
            int columns = secondMass.GetUpperBound(1) + 1;
            int max;

            for (int i = 0; i < rows; i++)
            {
                max = secondMass[i, 0];

                for (int j = 0; j < columns; j++)
                {
                    if (max < secondMass[i, j])
                    {
                        max = secondMass[i, j];
                    }
                }
                Console.WriteLine($"For {i + 1} row max: {max}");
            }

            //Third task

            int startWord = 0;
            int finishWord = 0;
            Console.Write("\nThird task\nEnter file path: ");
            string myFirstString = Console.ReadLine();
            finishWord = myFirstString.LastIndexOf('.');
            startWord = myFirstString.LastIndexOf('\\') + 1;
            
            if (finishWord == -1)
            {
                finishWord = myFirstString.Length;
            }
            
            Console.WriteLine(myFirstString.Substring(startWord, finishWord - startWord));

            //Fourth task

            Console.WriteLine("\nFourth task\nEnter your text:");
            //string mySecString = Console.ReadLine();
            string mySecString = @"sdfsdf    dsfsdf  sds    dfsdf    dsfsdf nsd
fsdf    ssdd   sdfsd";
            Regex regex = new Regex(@"\W");
            mySecString = regex.Replace(mySecString, " ");
            Console.WriteLine(mySecString);
            string[] words = mySecString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"The number of lines in the given text: {words.Length}");

        }
    }
}
