// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;

namespace HomeWork
{
    class TaskThree
    {
        static void Main()
        {
            var newArr = ShowArray();
        }
        static int[] ShowArray()
        {
            System.Console.WriteLine("Enter size of array: ");
            int size;
            bool check;
            check = Int32.TryParse(Console.ReadLine(), out size);
            if (!check)
            {
                System.Console.WriteLine("Invalid data, get reserve size (8)");
                size = 8;
            }
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = new Random().Next(1, 100);
                if (i != size - 1) System.Console.Write($"{arr[i]}, ");
                else System.Console.WriteLine($"{arr[i]}");
            }
            return arr;        
        }
    }
}