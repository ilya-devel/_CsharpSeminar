using System;

namespace taskSix
{
    class Task
    {
        static void Main()
        {
            Console.WriteLine("Введите целое 3-х значное число: ");
            string num = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Последнее цифра в числе: " + num[num.Length-1]);
            int num2 = Convert.ToInt32(num);
            Console.WriteLine("Другой способ определения 3 числа: " + (num2 % 10));
            if ((num2 > 0) && (num2 < 1000))
            {
                Console.WriteLine("Трехзначное состоит из чисел: ");
                Console.WriteLine((num2 / 100) + " " + (num2 % 100 / 10) + " " + (num2 % 10));
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write(num[i] + ", ");
                }
            }
        }
    }
}