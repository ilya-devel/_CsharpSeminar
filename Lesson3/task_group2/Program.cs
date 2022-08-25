// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21 

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
                System.Console.WriteLine("Вы указали не верную размерность, принята размерность по умолчанию (2)");
                size = 2;
            }
            System.Console.WriteLine();

            System.Console.WriteLine("Enter A point coordinate: ");
            double[] A = GetPoint(size);
            System.Console.WriteLine();
            System.Console.WriteLine("Enter B point coordinate: ");
            double[] B = GetPoint(size);
            System.Console.WriteLine();
            double tmp = 0;
            for (int i = 0; i < size; i++) tmp = tmp + Math.Pow(A[i] - B[i], 2);
            System.Console.WriteLine($"Distance equal: {Math.Sqrt(tmp)}");
        }
        static double[] GetPoint(int size)
        {
            double[] point = new double[size];
            for (int i = 0; i < size; i++) point[i] = GetNum($"{i}");
            return point;
        }
        static double GetNum(string msg)
        {
            double poi = -9999999;
            try
            {
                System.Console.WriteLine($"Enter coordinate {msg} point");
                poi = Convert.ToDouble(System.Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("Invalid numbe!");
            }
            return poi;
        }
    }
}