using System;

namespace TaskFour
{
    class Task
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1*num2 == num3 || num3*num2 == num1 || num1*num3 == num2)
            {
                Console.WriteLine("Одно из чисел произведение двух других");
            }
            else
            {
                Console.WriteLine("Нет ни одного числа, которое является произведением других");
            }

        }
    }
}