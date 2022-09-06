// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

using System;

namespace tsk_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GetArray();
            System.Console.WriteLine("Оригинальный массив: ");
            ShowArray(arr);
            int[] copyArr = GetCopyArray(arr);
            System.Console.WriteLine("Скопированный массив: ");
            ShowArray(copyArr);
        }
        static int[] GetArray()
        {
            System.Console.WriteLine("Введите размер массива: ");
            int size;
            bool checking = Int32.TryParse(Console.ReadLine(), out size);
            if (!checking)
            {
                System.Console.WriteLine("Не верный размер, принят размер по умолчанию (10)");
                size = 10;
            }
            int[] array = new int[size];
            for (int i = 0; i < size; i++) array[i] = new Random().Next(-9, 9);
            return array;
        }
        static int[] GetCopyArray(int[] array)
        {
            int[] newArr = new int[array.Length];
            for (int i = 0 ; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }
            return newArr;
        }
        static void ShowArray(int[] array)
        {
            System.Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) System.Console.Write($"{array[i]}  ");
                else System.Console.Write($"{array[i]}");
            }
            System.Console.Write(" ]\n");
        }
    }
}
