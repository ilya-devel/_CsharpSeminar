// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 

using System;

namespace LessonFive
{
    class GroupTaskOne
    {
        static void Main()
        {
            var arr = GetArray();
            System.Console.WriteLine("\nGet array: ");
            foreach (var item in arr) System.Console.Write($"{item} ");
            System.Console.WriteLine("\n");
            arr = ReverseArray(arr);
            System.Console.WriteLine("Array after reverse: ");
            foreach (var item in arr) System.Console.Write($"{item} ");
            System.Console.WriteLine("\n");
        }
        static int[] GetArray()
        {
            System.Console.WriteLine("Enter size of array: ");
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
        static int[] ReverseArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++) array[i] = array[i] * -1;
            return array;
        }
    }
}