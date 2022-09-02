// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

using System;

namespace HomeWorks
{
    class TaskOne
    {
        static void Main()
        {
            var arr = GetArray(-100, -1);
            System.Console.WriteLine("Принят следующий массив:");
            ShowArray(arr);
            System.Console.WriteLine();
            System.Console.WriteLine($"Разница между минимальным и максимальным числом равна: {GetDifferenceMinAndMax(arr)}");
        }
        static double[] GetArray(int MinValue = 100, int Multiple = 10)
        {
            System.Console.WriteLine("Введите размер массива: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int size);
            if (!check)
            {
                System.Console.WriteLine("Размер указан не корректно, принят размер по умолчанию (10)!");
                size = 10;
            }
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                double num = new Random().NextDouble();
                int multp = new Random().Next(MinValue, MinValue * Multiple);
                array[i] = Math.Round((num * multp), 2);
            }
            return array;
        }
        static void ShowArray(double[] array)
        {
            System.Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) System.Console.Write($"{array[i]}  ");
                else System.Console.Write($"{array[i]}");
            }
            System.Console.Write(" ]\n");
        }
        static double GetDifferenceMinAndMax(double[] array)
        {
            double Min = array[0], Max = array[0];
            foreach (var item in array)
            {
                if (item < Min) Min = item;
                else if (item > Max) Max = item;
            }
            System.Console.WriteLine($"Минимальное число = {Min} : Максимальное число = {Max}");
            return Max - Min;
        }
    }
}