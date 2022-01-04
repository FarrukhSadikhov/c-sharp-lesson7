using System;

namespace recursion5
{
    class Program
    {
        enum Days
        {
            Monday =1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static int Checker(string n)
        {
            int x = 0;
            do
            {
                try
                {
                    Console.Write(n);
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x > 7)
                    {
                        Console.WriteLine("Ошибка,такого дня недели нет");
                        continue;
                    }
                    else if (x < 1)
                    {
                        Console.WriteLine("Ошибка,такого дня недели нет");
                        continue;
                    }

                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка,вводите корректные данные");
                    continue;
                }
            }
            while (true);
            return x;
        }
        static void Main(string[] args)
        {
            // Задание 5: Написать программу, которая выдает день недели на английском языке по номеру дня недели(Использовать ENUM).
            int x = Checker("Введите число :");
            Console.WriteLine((Days)x);
            Console.ReadKey();
        }
    }
}
