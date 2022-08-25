// Напишите программу, которая считывает с консоли числа (по одному в строке) до тех пор, пока сумма введённых чисел не будет равна 0 и сразу после этого выводит сумму квадратов всех считанных чисел.

using System;

namespace HomeWork
{
    class HomeWorkFour
    {
        static void Main()
        {
            System.Console.WriteLine("ВЫЧИСЛЕНИЕ СУММЫ КВАДРАТОВ ВВЕДЁННЫХ ЧИСЕЛ");
            System.Console.WriteLine();
            System.Console.WriteLine($"Сумма квадратов введённых чисел равна: {AnalyzeNum()}");
        }
        static double GetNum()
        {
            System.Console.WriteLine("Введите число:");
            double tmp;
            bool check = Double.TryParse(Console.ReadLine(), out tmp);
            if (!check)
            {
                System.Console.WriteLine("Не верные данные!");
                tmp = 0;
            }
            return tmp;
        }
        static double AnalyzeNum()
        {
            double sum = 0;
            double main = 0;
            do
            {
                double num = GetNum();
                main = main + num;
                sum = sum + Math.Pow(num, 2);
            } while (main != 0);
            return sum;
        }
    }
}