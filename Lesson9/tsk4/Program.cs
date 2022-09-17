// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии. A = 3; B = 5 -> 243 (3⁵) A = 2; B = 3 -> 8 

using System;

namespace LessonNine
{
    class Program

    {
        static void Main()
        {
            int number = GetSizeValues("число");
            int mult = GetSizeValues("степень");
            System.Console.WriteLine($"{MyMathPow(number, mult)}");
        }
        static int GetSizeValues(string key = "элементов")
        {
            System.Console.WriteLine($"Введите {key}: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int values);
            if (!check)
            {
                System.Console.WriteLine("Не верно указаны данные, принята величина по умолчанию (3)!");
                values = 3;
            }
            return values;
        }
        static int MyMathPow(int num, int mult)
        {
            if (mult == 1) return num;
            else return num * MyMathPow(num, mult - 1);
        }
    }
}