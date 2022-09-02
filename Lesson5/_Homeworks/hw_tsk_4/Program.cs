// Напишите программу, которая принимает на вход число любой размерности и проверяет, является ли оно палиндромом.

using System;

namespace HomeWork
{
    class HomeWorkOne
    {
        static void Main()
        {
            long number = GetNum();
            if (number != -1)
            {
                string ans = CheckPalindrom(number) ? "": "НЕ ";
                System.Console.WriteLine($"Указанное число {ans}палидром");
            }
        }
        static long GetNum()
        {
            System.Console.WriteLine("Введите положительное целое число: ");
            long num;
            bool check = long.TryParse(Console.ReadLine(), out num);
            if (!check) 
            {
                System.Console.WriteLine("Вы ввели не верное число!");
                num = -1;
            }
            return num;
        }
        static bool CheckPalindrom(long num)
        {
            if (num < 0) return false;
            if (num < 10) return true;

            long tmp = num;
            long chk = 0;
            long dg = 0;

            while (tmp != 0)
            {
                dg = tmp % 10;
                chk = chk * 10 + dg;
                tmp /= 10;
            }
            return (chk == num);
        }
    }
}