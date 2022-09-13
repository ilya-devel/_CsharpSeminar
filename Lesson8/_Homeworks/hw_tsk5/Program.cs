// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

using System;
using System.Collections.Generic;

namespace LessonEight
{
    class Program

    {
        static void Main()
        {
            int row = GetSizeValues($"строк");
            int col = GetSizeValues($"столбцов");
            int[,] arr = GetFill2DArray(row, col);
            Show2DArray(arr);
            System.Console.WriteLine();
        }
        static int GetSizeValues(string key = "элементов")
        {
            System.Console.WriteLine($"Введите количество {key}: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int values);
            if (!check)
            {
                System.Console.WriteLine("Не верно указаны данные, принята величина по умолчанию (3)!");
                values = 3;
            }
            return values;
        }
        static int[,] GetFill2DArray(int row, int col)
        {
            int[,] array = new int[row, col];
            int minX, maxX, minY, maxY, count;
            count = 1;
            minX = 0;
            minY = 0;
            maxX = col - 1;
            maxY = row - 1;
            while (count <= row * col)
            {
                for (int side = 0; side < 4; side++)
                {
                    if (side == 0)
                    {
                        for (int x = minX; x <= maxX; x++) array[minY, x] = count++;
                        minY++;
                    }
                    if (side == 1)
                    {
                        for (int x = minY; x <= maxY; x++) array[x, maxX] = count++;
                        maxX--;
                    }
                    if (side == 2)
                    {
                        for (int x = maxX; x >= minX; x--) array[maxY, x] = count++;
                        maxY--;
                    }
                    if (side == 3)
                    {
                        for (int x = maxY; x >= minY; x--) array[x, minX] = count++;
                        minX++;
                    }
                }
            }
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i, j]:d2} ");
                System.Console.WriteLine();
            }
        }
    }
}