using System;

namespace recursion1
{
    class Program
    {
        // Задание 1: Найти сумму 2(2) + 2(3) + 2(4) + … + 2(10). Операцию возведения в степень не использовать.
        static int Degree(int n)
        {
            if (n == 2)
            {
                return 4;
            }
            else
            {
                return 2 * Degree(n - 1);
            }
        }
        static int Sum(int n)
        {
            if (n == 2)
            {
                return 4;
            }
            else
            {
                return Sum(n - 1) + Degree(n);
            }
        }
        static void Main(string[] args)
        {
            int n = 10;
            n = Sum(n);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}


