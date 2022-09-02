// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

namespace HomeWorks
{
    class TaskOne
    {
        static void Main()
        {
            var arr = GetArray();
            System.Console.WriteLine("Принят следующий массив:");
            ShowArray(arr);
            System.Console.WriteLine();
            System.Console.WriteLine($"Количество чётных чисел в массиве равно: {GetEvenCount(arr)}");
        }
        static int[] GetArray(int MinValue = 100, int Multiple = 10)
        {
            System.Console.WriteLine("Введите размер массива: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int size);
            if (!check)
            {
                System.Console.WriteLine("Размер указан не корректно, принят размер по умолчанию (10)!");
                size = 10;
            }
            int[] array = new int[size];
            for (int i = 0; i < size; i++) array[i] = new Random().Next(MinValue, MinValue * Multiple);
            return array;
        }
        static void ShowArray(int[] array)
        {
            System.Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) System.Console.Write($"{array[i]}, ");
                else System.Console.Write($"{array[i]}");
            }
            System.Console.Write(" ]\n");
        }
        static int GetEvenCount(int[] array)
        {
            int count = 0;
            foreach (var item in array) if (item % 2 == 0) count++;
            return count;
        }
    }
}