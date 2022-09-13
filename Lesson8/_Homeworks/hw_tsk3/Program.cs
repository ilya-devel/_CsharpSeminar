// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 

using System;
using System.Collections.Generic;

namespace LessonEight
{
    class Program

    {
        static void Main()
        {
            var listMatrix = new List<int[,]>();
            for (int i = 0; i < 2; i++)
            {
                int row = GetSizeValues($"строк для {i + 1} матрицы");
                int col = GetSizeValues($"столбцов для {i + 1} матрицы");
                int[,] arr = GetFill2DArray(row, col);
                Show2DArray(arr);
                listMatrix.Add(arr);
                System.Console.WriteLine();
            }
            GetMultiply2DMatrix(listMatrix);
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
            for (int i = 0; i < row; i++) for (int j = 0; j < col; j++) array[i, j] = new Random().Next(1, 10);
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i, j]} ");
                System.Console.WriteLine();
            }
        }
        static void GetMultiply2DMatrix(List<int[,]> lstMatrix)
        {
            if (lstMatrix[0].GetLength(1) != lstMatrix[1].GetLength(0)) System.Console.WriteLine("Нельзя найти произведение данных матриц");
            else
            {
                int[,] newMatrix = new int[lstMatrix[0].GetLength(0), lstMatrix[1].GetLength(1)];
                for (int i = 0; i < newMatrix.GetLength(0); i++)
                    for (int j = 0; j < newMatrix.GetLength(1); j++)
                        {
                            newMatrix[i, j] = 0;
                            for (int x = 0; x < lstMatrix[0].GetLength(1); x++)
                                newMatrix[i,j] += lstMatrix[0][i,x] * lstMatrix[1][x,j];
                        }
                Show2DArray(newMatrix);
            }
        }
    }
}