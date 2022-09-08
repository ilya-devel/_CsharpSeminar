// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран. m = 3, n = 4. 0 1 2 3 1 2 3 4 2 3 4 5 

using System;

namespace LessonSeven
{
    class ExampleOne
    {
        static void Main()
        {
            int row = GetSizeValues("строк");
            int col = GetSizeValues("столбцов");
            Show2DArray(GetFill2DArray(row, col));
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
            for (int i = 0; i < row; i++) for (int j = 0; j < col; j++) array[i,j] = i + j;
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i,j]:d2} ");
                System.Console.WriteLine();
            }
        }
    }
}