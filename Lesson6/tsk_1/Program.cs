// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

using System;

namespace tsk_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GetArray();
            ShowArray(arr);
            arr = ReverseArrayFirst(arr);
            ShowArray(arr);
            arr = ReverseArraySecond(arr);
            ShowArray(arr);
        }
        static int[] ReverseArrayFirst(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i=0; i < newArr.Length;i++) newArr[i] = arr[arr.Length-1-i];
            return newArr;
        }
        static int[] ReverseArraySecond(int[] arr)
        {
            for (int i=0; i < arr.Length/2;i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length-1-i];
                arr[arr.Length-1-i] = tmp;
            }
            return arr;
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
    }
}
