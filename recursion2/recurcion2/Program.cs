using System;

namespace recurcion2
{
    class Program
    {
        //Задание 2: Написать рекурсивную функцию нахождения наибольшего общего делителя двух целых чисел.

        static int DividerNumber(int number1,int number2)
        {
          if (number2 == 0)
            {
                return number1;
            }
            else
            {
                return DividerNumber(number2, number1 % number2);
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
            int number1 = Checker("Введите первое число :");
            int number2 = Checker("Введите второе число :");
            Console.WriteLine(DividerNumber(number1,number2));
            Console.ReadKey();
        }
    }
}
