// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;

namespace TaskGroup
{
    class TaskGroupThree
    {
        static void Main()
        {
            System.Console.WriteLine("ВЫВОД ЗНАЧЕНИЙ ЦЕЛЫХ ПОЛОЖИТЕЛЬНЫХ ЧИСЕЛ ДО ЧИСЛА N (ПО-УМОЛЧАНИЮ СТЕПЕНЬ 3) \n");
            System.Console.WriteLine("Введите степень:");
            int size;
            bool check = Int32.TryParse(Console.ReadLine(), out size);
            if (check == false)
            {
                System.Console.WriteLine("Вы указали не верную степень, принята степень по умолчанию (3)");
                size = 3;
            }
            System.Console.WriteLine();
            
            
            int maxi = GetNum();
            if (maxi != -1 && maxi != 0)
            {
                for (int i = 1; i <= maxi; i++)
                {
                    double tmp = Math.Pow(i, size);
                    if (i != maxi) System.Console.Write($"{tmp}, ");
                    else System.Console.Write($"{tmp}");
                }
            }
            System.Console.WriteLine();
        }
        static int GetNum()
        {
            System.Console.WriteLine("Укажите положительное целое число до которого нужно выводить кубические значения: ");
            int num = -1;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num <= 0) System.Console.WriteLine("Введённое число меньше либо равно 0!");
            }
            catch
            {
                System.Console.WriteLine("Не верное значение");
            }
            return num;
        }
    }
}