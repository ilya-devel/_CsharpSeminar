// Напишите программу, которая принимает на вход координаты точек и находит расстояние между ними в N-мерном пространстве. N - задается пользователем.

using System;

namespace TaskGroup
{
    class TaskGroupTwo
    {
        static void Main()
        {
            System.Console.WriteLine("РАСЧЁТ РАССТОЯНИЯ МЕЖДУ 2 ТОЧКАМИ \n");
            System.Console.WriteLine("Введите размерность координат:");
            int size;
            bool check = Int32.TryParse(Console.ReadLine(), out size);
            if (check == false)
            {
                System.Console.WriteLine("Вы указали не верную размерность, принята размерность по умолчанию (3)");
                size = 3;
            }
            System.Console.WriteLine();

            System.Console.WriteLine("Введите координаты точки А: ");
            double[] A = GetPoint(size);
            System.Console.WriteLine();
            System.Console.WriteLine("Введите координаты точки Б: ");
            double[] B = GetPoint(size);
            System.Console.WriteLine();
            double tmp = 0;
            for (int i = 0; i < size; i++) tmp = tmp + Math.Pow(A[i] - B[i], 2);
            System.Console.WriteLine($"Дистанция между точками равна: {Math.Sqrt(tmp)}");
        }
        static double[] GetPoint(int size)
        {
            double[] point = new double[size];
            for (int i = 0; i < size; i++) point[i] = GetNum($"{i + 1}");
            return point;
        }
        static double GetNum(string msg)
        {
            double poi;
            try
            {
                System.Console.WriteLine($"Введите координаты по {msg} оси");
                poi = Convert.ToDouble(System.Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("Не верное значение, будут указаны нулевые координаты");
                poi = 0;
            }
            return poi;
        }
    }
}