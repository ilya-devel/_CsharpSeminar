// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;

namespace HomeWork
{
    class HomeWorkOne
    {
        static void Main()
        {
            int number = GetNum();
            if (number != -1)
            {
                string ans = CheckPalindrom(number) ? "": "НЕ ";
                System.Console.WriteLine($"Указанное число {ans}палидром");
            }
        }
        static int GetNum()
        {
            System.Console.WriteLine("Введите положительное целое число: ");
            int num;
            bool check = Int32.TryParse(Console.ReadLine(), out num);
            if (!check) 
            {
                System.Console.WriteLine("Вы ввели не верное число!");
                num = -1;
            }
            return num;
        }
        static bool CheckPalindrom(int num)
        {
            if (num < 0) return false;
            if (num < 10) return true;

            int tmp = num;
            int chk = 0;
            int dg = 0;

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