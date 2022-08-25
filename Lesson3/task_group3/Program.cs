// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4 

using System;

namespace TaskGroup
{
    class TaskGroupThree
    {
        static void Main()
        {

            int maxi = GetNum();
            if (maxi != -1)
            {
                for (int i = 1; i <= maxi; i++)
                {
                    if (i != maxi) System.Console.Write($"{i*i}, ");
                    else System.Console.Write($"{i*i}");
                }
            }
            System.Console.WriteLine();
        }
        static int GetNum()
        {
            System.Console.WriteLine("Enter maximal num for table: ");
            int num = -1;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("Ivalid number");
            }
            return num;
        }
    }
}