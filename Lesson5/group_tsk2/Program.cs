// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да 

using System;

namespace LessonFive
{
    class GroupTaskTwo
    {
        static void Main()
        {
            var arr = GetArray();
            System.Console.WriteLine("\nGet array: ");
            foreach (var item in arr) System.Console.Write($"{item} ");
            System.Console.WriteLine("\n");
            System.Console.WriteLine("Enter number for searching: ");
            // int check = Convert.ToInt32(Console.ReadLine());
            int check;
            bool checkGetValue = Int32.TryParse(Console.ReadLine(), out check);
            if (!checkGetValue)
            {
                System.Console.WriteLine("Invalid value, got first values of array");
                check = arr[0];
            }
            string checking = CheckValue(arr, check) ? "Yes": "No";
            System.Console.WriteLine($"Is there number in array: {checking}");
        }
        static int[] GetArray()
        {
            System.Console.WriteLine("Enter size of array: ");
            // int size = Convert.ToInt32(System.Console.ReadLine());
            int size;
            bool checking = Int32.TryParse(Console.ReadLine(), out size);
            if (!checking)
            {
                System.Console.WriteLine("Invalid value, got main size (10)");
                size = 10;
            }
            int[] array = new int[size];
            for (int i = 0; i < size; i++) array[i] = new Random().Next(-9, 9); 
            return array;
        }
        static bool CheckValue(int[] array, int check)
        {
            foreach (var item in array) if (item == check) return true;
            return false;
        }
    }
}