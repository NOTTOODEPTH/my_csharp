using System;
namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. С помощью цикла с постусловием вывести на экран в столбик последовательность чисел : -20, -40, ...,-100.
            Console.WriteLine("1.Using a loop with a postcondition, display a sequence of numbers on the screen in a column: -20, -40, ..., -100.");
            sbyte firstTask = 0;
            do
            {
                firstTask -= 20;
                Console.WriteLine(firstTask);
            }
            while (firstTask > -100);
            // 2. С помощью цикла со счетчиком вывести на экран в одну строку все двузначные числа, кратные 5.
            Console.WriteLine("2.Using a loop with a counter, display all two-digit numbers that are multiples of 5 on one line.");
            for (sbyte secondTask = 10; secondTask < 100; secondTask++)
            {
                if (secondTask % 5 == 0)
                {
                    Console.Write($"{secondTask} ");
                }
            }
            // 3. Найти среднее арифметическое и сумму всех целых чисел от а до b включительно.
            Console.WriteLine("\n3.Find the arithmetic mean and the sum of all integers from a to b inclusive.");
            int a = 0, b = 0;
            double sum = 0;
            int count = 0;
            string? myString;
            bool check;
            
            int checkInt(int  thisInt, char nameInt)
            {
                do
                {
                    Console.Write($"Enter the number {nameInt}: ");
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
                    
            a=checkInt(a,'a');
            b=checkInt(b,'b');
            
            if (a >= b)
            { 
                for (; b <= a; b++)
                {
                    count++;
                    sum += b;
                }
            }
            else 
            {
                for (; a <= b; a++)
                {
                    count++;
                    sum += a;
                }
            }
           
            Console.WriteLine($"Arithmetical mean: {sum / count}");
            Console.WriteLine($"The sum of all integers: {sum}");
        }
    }
}