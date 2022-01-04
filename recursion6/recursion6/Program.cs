using System;


namespace recursion6
{
    class Program
    {
        static int CheckNum()
        {
            int y;
            Int32.TryParse(Console.ReadLine(), out y);
            if (y < 1000 || y > 9999)
            {
                while (y < 1000 || y > 9999)
                {
                    Console.WriteLine("Введено недопустимое значение, пожалуйста повторите ввод:");
                    Int32.TryParse(Console.ReadLine(), out y);
                }
            }
            return y;
        }  
        static void Main(string[] args)
            {
            /* Задание 6: Написать игру «Быки и коровы».
             Программа "загадывает (Цифры не должны повторяться)" четырёхзначное число и играющий должен угадать его.
             После ввода пользователем числа программа сообщает,
             сколько цифр числа угадано(быки) и сколько цифр угадано и стоит на нужном месте(коровы).
             После отгадывания числа на экран необходимо вывести количество сделанных пользователем попыток.
             В программе необходимо использовать рекурсию.*/

            Console.WriteLine("Введите четорёх значное число: ");
           
            Random num = new Random();
            int x = num.Next(1000, 9999);
            int a = x / 1000;
            int b = (x / 100) % 10;
            int c = (x / 10) % 10;
            int d = x % 10;
                             
           /* if ((a == b) || (a == c) || (a == d) || (b == c) || (b == d) || (c == d))
            {
                
            }

            Console.WriteLine(x);*/

            int bulls = 0;
            int cows = 0;

            int y = CheckNum();
            int a1 = y / 1000;
            int b1 = (y / 100) % 10;
            int c1 = (y / 10) % 10;
            int d1 = y % 10;

            if (a == a1) { bulls++; }
            if (b == b1) { bulls++; }
            if (c == c1) { bulls++; }
            if (d == d1) { bulls++; }

            if (a == b1) { cows++; }
            if (a == c1) { cows++; }
            if (a == d1) { cows++; }

            if (b == a1) { cows++; }
            if (b == c1) { cows++; }
            if (b == d1) { cows++; }

            if (c == a1) { cows++; }
            if (c == b1) { cows++; }
            if (c == d1) { cows++; }

            if (d == a1) { cows++; }
            if (d == b1) { cows++; }
            if (d == c1) { cows++; }

            /* if ((bulls == 4) && (cows == 0)) { Console.WriteLine("Congrats. You win!!!"); }
             else { Console.WriteLine("Try again :("); }*/
            /* Console.WriteLine("Bulls: " + bulls);
             Console.WriteLine("Cows: " + cows);*/

            if ((bulls == 4) || (cows == 0))
            {
                while ((bulls == 4) && (cows == 0))
                {
                    Console.WriteLine("Congrats. You win!!!");
                }
            }
            else
            {
                Console.WriteLine("Try again :(");
                Console.WriteLine("Bulls: " + bulls);
                Console.WriteLine("Cows: " + cows);
            }

/*            Random myvalue = new Random();
            int mygeneratedvalue = MyRandom(myvalue);

        }
        static int MyRandom(Random myvalue)
        {
            int mydigits;
            mydigits = myvalue.Next(1000, 10000);
            //proverka povtorov v 4-x znachnom chisle
            if ((a == b) || (a == c) || (a == d) || (b == c) || (b == d) || (c == d))
            {
                return MyRandom(myvalue);
            }
            return mydigits;*/

        }


    }
}
