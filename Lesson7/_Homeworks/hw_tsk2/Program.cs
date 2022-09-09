// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

namespace LessonSeven
{
    class ExampleOne
    {
        static void Main()
        {
            int row = GetIntegerValues("Введите количество строк: ");
            int col = GetIntegerValues("Введите количество столбцов: ");
            int[,] arr = GetFill2DArray(row, col);
            System.Console.WriteLine();
            System.Console.WriteLine("Сгенерированный массив: ");
            Show2DArray(arr);
            System.Console.WriteLine();
            GetPositionElementIn2DArray(arr);
        }
        static int GetIntegerValues(string key = "Введите целое число: ")
        {
            System.Console.WriteLine(key);
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
            for (int i = 0; i < row; i++) for (int j = 0; j < col; j++) 
            {
                array[i, j] = new Random().Next(1, 100);
            }
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i, j]:d2}\t");
                System.Console.WriteLine();
            }
        }
        static void GetPositionElementIn2DArray(int[,] array)
        {
            System.Console.WriteLine("Начинаем проверку элемента по позиции.");
            int row = GetIntegerValues("Введите интересующую строку, начиная с 1: ");
            int col = GetIntegerValues("Введите интересующую столбец, начиная с 1: ");
            try 
            {
                System.Console.WriteLine($"Значение по данной позиции равно: {array[row - 1, col - 1]}");
            }
            catch
            {
                System.Console.WriteLine("Данной позиции не существует");
            }
        }
    }
}