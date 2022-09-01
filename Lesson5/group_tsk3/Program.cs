// Задача 35: Задайте одномерный массив из 15 случайных чисел от -50 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5 элементов. В своём решении сделайте для 15 [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0 [10, 11, 12, 13, 14] -> 5

using System;

namespace LessonFive
{
    class GroupTaskThree
    {
        static void Main()
        {
            var array = GetArray();
            System.Console.WriteLine("Получен массив: ");
            foreach (var num in array) System.Console.Write($"{num} ");
            int check = CountValues(array);
            System.Console.WriteLine($"\nКоличество элементов массива в диапазоне от 10 до 99 равно: {check}");
        }
        static int[] GetArray()
        {
            int size = 15;
            int[] array = new int[size];
            for (int i = 0; i < size; i++) array[i] = new Random().Next(-50, 101); 
            return array;
        }
        static int CountValues(int[] array)
        {
            int count=0;
            foreach (int item in array) if (item >= 10 && item <= 99) count++;
            return count;
        }
    }
}