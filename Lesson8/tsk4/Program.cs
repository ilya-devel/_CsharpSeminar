// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива

using System;
using System.Collections.Generic;

namespace LessonEight
{
    class Program

    {
        static void Main()
        {
            int row = GetSizeValues("строк");
            int col = GetSizeValues("столбцов");
            int[,] arr = GetFill2DArray(row, col);
            Show2DArray(arr);
            System.Console.WriteLine();
            int[,] newArr = DeleteCrossForMinValue(arr, GetMinElementWithPosition(arr));
            Show2DArray(newArr);
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
            for (int i = 0; i < row; i++) for (int j = 0; j < col; j++) array[i, j] = new Random().Next(1, 100);
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
        static (int minValue, int row, int col) GetMinElementWithPosition(int[,] array)
        {
            int minValue = array[0, 0];
            int row = 0;
            int col = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] < minValue)
                    {
                        minValue = array[i, j];
                        row = i;
                        col = j;
                    }
            return (minValue, row, col);
        }
        static int[,] DeleteCrossForMinValue(int[,] array, (int minValue, int row, int col) minValue)
        {
            int[,] newArr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
            System.Console.WriteLine($"Удаляем пересечение с минимальным значением {minValue.minValue} (row {minValue.row}, col {minValue.col})");
            int row = 0;
            int col = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == minValue.row) continue;
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (j == minValue.col) continue;
                        else
                        {
                            newArr[row, col] = array[i, j];
                            col++;
                        }
                    }
                    col = 0;
                    row++;
                }
            }
            return newArr;
        }
    }
}