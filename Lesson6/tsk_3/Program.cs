// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное

using System;

namespace tsk_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetUserNum();
            System.Console.WriteLine($"Число в двоичной системе равно: {Convert.ToString(num, 2)}");
        }
        static int GetUserNum()
        {
            System.Console.WriteLine($"Введите число для конвертации: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int num);
            if (!check)
            {
                System.Console.WriteLine("Не верное число, принято число по умолчанию: ");
                num = 1;
            }
            return num;
        }
    }
}
