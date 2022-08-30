// написать программу, где уже реализовано заполнение массива случайными числами. И в этом массиве надо найти максимум и его индекс, минимум и его индекс, среднее арифметическое всех элементов массива. Всё это обернуть в функции. 

using System;

namespace Task
{
    class TaskTwo
    {
        static void Main()
        {
            int[] array = ShomIntArray();
            System.Console.WriteLine($"Mean value equal: {MeanValue(array):f2}");
            int[] minValue = MinValue(array);
            System.Console.WriteLine($"Min value equal: {minValue[1]}. Its index equal: {minValue[0]}");
            int[] maxValue = MaxValue(array);
            System.Console.WriteLine($"Min value equal: {maxValue[1]}. Its index equal: {maxValue[0]}");
        }
        static int[] ShomIntArray()
        {
            System.Console.WriteLine("Enter length of array: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = new Random().Next(1, 100);
                if (i != len - 1) System.Console.Write($"{arr[i]}, ");
                else System.Console.Write($"{arr[i]}");
            }
            System.Console.WriteLine();
            return arr;
        }
        static double MeanValue(int[] array)
        {
            double sum = 0;
            foreach (var item in array) sum += item;
            return sum / array.Length;
        }
        static int[] MinValue(int[] array)
        {
            int[] minValue = new int[2];
            minValue[0] = 0;
            minValue[1] = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[minValue[0]] > array[i])
                {
                    minValue[0] = i;
                    minValue[1] = array[i];
                }
            }
            return minValue;
        }
        static int[] MaxValue(int[] array)
        {
            int[] maxValue = new int[2];
            maxValue[0] = 0;
            maxValue[1] = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[maxValue[0]] < array[i])
                {
                    maxValue[0] = i;
                    maxValue[1] = array[i];
                }
            }
            return maxValue;
        }
    }
}