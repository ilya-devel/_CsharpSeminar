// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

using System;

namespace hw_tsk2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Получаем данные для поиска точки пересечения двух линий:");
            System.Console.WriteLine("Данные для первой линии: ");
            double[] pointOne = GetUserData();
            System.Console.WriteLine("Данные для второй линии: ");
            double[] pointTwo = GetUserData();
            GetPointCross(pointOne, pointTwo);
        }
        static double[] GetUserData()
        {
            char[] key = {'k', 'b'};
            double[] point = new double[2];
            for (int i = 0; i < point.Length; i++) point[i] = GetUserNum(i+1, key[i]);
            return point;
        }
        static double GetUserNum(int x, char key)
        {
            System.Console.WriteLine($"Введите {key} данные для поиска: ");
            bool check = Double.TryParse(Console.ReadLine(), out double num);
            if (!check)
            {
                System.Console.WriteLine("Не верное число, принято число по умолчанию (0): ");
                num = 0;
            }
            return num;
        }
        static void GetPointCross(double[] p1, double[] p2)
        {
            double X = (-1 * (p1[1] - p2[1]) / (p1[0] - p2[0]));
            double Y = p2[0] * X + p2[1];
            if (Double.IsNaN(X) || Double.IsNaN(Y)) System.Console.WriteLine("Полученные данные не верны, попробуйте ещё раз");
            else System.Console.WriteLine($"Точка пересечения двух прямых равна {X} : {Y}");
        }
    }
}
