// HARD SORT. Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры.
// Отсортировать элементы по возрастанию слева направо и сверху вниз. Например, задан массив: 1 4 7 2 5 9 10 3 После сортировки 1 2 3 4 5 7 9 10 

using System;

namespace LessonSeven
{
    class ExampleOne
    {
        static void Main()
        {
            int row = GetSizeValues("строк");
            int col = GetSizeValues("столбцов");
            int[,] arr = GetFill2DArray(row, col);
            System.Console.WriteLine("Сгенерированный массив: ");
            Show2DArray(arr);
            System.Console.WriteLine();
            arr = SortedArray(arr);
            System.Console.WriteLine("Отсортированный массив: ");
            Show2DArray(arr);

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
            for (int i = 0; i < row; i++) for (int j = 0; j < col; j++) array[i, j] = new Random().Next(1, 25);
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i, j]}\t");
                System.Console.WriteLine();
            }
        }
        static int[,] SortedArray(int[,] array)
        {
            int[] listValues = new int[array.GetLength(0) * array.GetLength(1)];
            int ind = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    listValues[ind] = array[i, j];
                    ind++;
                }
            Array.Sort(listValues);
            ind = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = listValues[ind];
                    ind++;
                }
            return array;
        }
    }
}