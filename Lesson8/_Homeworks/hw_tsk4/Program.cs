// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

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
            int layer = GetSizeValues("элементов в глубину");
            int[,,] arr = GetFill3DArray(row, col, layer);
            Show3DArray(arr);
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
        static int[,,] GetFill3DArray(int row, int col, int layer)
        {
            int countValues = row * col * layer;
            var listValues = new List<int>();
            int[,,] array = new int[row, col, layer];
            for (int l = 0; l < layer; l++)
                for (int r = 0; r < row; r++)
                    for (int c = 0; c < col; c++)
                    {
                        int tmp = 0;
                        do
                        {
                            tmp = new Random().Next(1, countValues * 2);
                        } while (listValues.Contains(tmp));
                        listValues.Add(tmp);
                        array[r, c, l] = tmp;
                    }
            return array;
        }
        static void Show3DArray(int[,,] array)
        {
            for (int l = 0; l < array.GetLength(2); l++)
                for (int r = 0; r < array.GetLength(0); r++)
                {
                    for (int c = 0; c < array.GetLength(1); c++)
                        if (c == array.GetLength(1) - 1) System.Console.Write($"  {array[r, c, l]:d3} onPos: r = {r}, c = {c}, l = {l}");
                        else System.Console.Write($"  {array[r, c, l]:d3} onPos: r = {r}, c = {c}, l = {l}  |");
                    System.Console.WriteLine();
                }
        }
    }
}