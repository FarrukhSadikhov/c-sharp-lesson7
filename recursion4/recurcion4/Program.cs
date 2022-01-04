using System;

namespace recurcion4
{
    class Program
    {
        static int SumNumber(int x, int y, ref int counter)
        {
            if (x > y + 1)
            {
                counter += x - 1;
                return SumNumber(x - 1, y, ref counter);
            }
            else if (x + 1 < y)
            {
                counter += y - 1;
                return SumNumber(x, y - 1, ref counter);
            }
            else
            {
                return counter;
            }
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
            /*Задание 4: Написать функцию,
            которая получает в качестве параметров 2 целых числа и возвращает сумму чисел из диапазона между ними. Рекурсия.*/
            int x = Checker("Введите первое число :");
            int y = Checker("Введите второе число :");            
            int counter = 0;
            Console.Write("Ответ :");
            Console.WriteLine(SumNumber(x, y,ref counter));
            Console.ReadKey();
        }
    }
}
