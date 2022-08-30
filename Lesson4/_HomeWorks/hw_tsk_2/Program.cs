// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using System;

namespace HomeWork
{
    class Task
    {
        static void Main()
        {
            CountNumber();
        }
        static void CountNumber()
        {
            System.Console.WriteLine("Enter positive integer number: ");
            int tmp, count, num = Convert.ToInt32(Console.ReadLine());
            tmp = num;
            count = 0;
            while (tmp > 0)
            {
                count += tmp%10;
                tmp = tmp/10;
            }
            System.Console.WriteLine($"Summary of numbers equal: {count}");
        }
    }
}