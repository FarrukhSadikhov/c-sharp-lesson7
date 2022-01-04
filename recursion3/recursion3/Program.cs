using System;

namespace recursion3
{
    class Program
    {
        // Задание 3: Написать рекурсивную функцию нахождения степени числа.
        static double Degree(double x,double y)
        {           
            if (y == 0)
            {
                return 1;
            }
            else
            {
                return x * Degree(x,y - 1);
            }           
        }
        static double Checker(string n)
        {
            double x = 0;
            do
            {
                try
                {
                    Console.Write(n);
                    x = Convert.ToDouble(Console.ReadLine());                   
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
            double x = Checker("Введите число :");
            double y = Checker("Введите степень :");
            Console.Write("Ответ :");
            Console.WriteLine(Degree(x,y));
            Console.ReadKey();
        }
    }
}
