// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя

using System;

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
            Show2DArray(Turn2DArray(arr));
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
        static int[,] Turn2DArray(int[,] array)
        {
            if (array.GetLength(0) != array.GetLength(1))
            {
                System.Console.WriteLine("Длина строк и столбцов не равны, возвращаем исходный массив!");
                return array;
            }
            else
            {
                int[,] newArr = new int[array.GetLength(1), array.GetLength(0)];
                for (int i = 0; i < array.GetLength(0); i++)
                    for (int j = 0; j < array.GetLength(1); j++)
                        newArr[i, j] = array[j, i];
                return newArr;
            }
        }
    }
}