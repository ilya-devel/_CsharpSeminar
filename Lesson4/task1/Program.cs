// Задача 30: Напишите программу, которая выводит массив из N элементов, заполненный случайными целыми числами. N - целое число и задается с клавиатуры. 

using System;

namespace Task
{
    class TaskOne
    {
        static void Main()
        {
            ShomIntArray();
        }
        static void ShomIntArray()
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
        }
    }
}