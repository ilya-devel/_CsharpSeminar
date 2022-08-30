// Написать программу, которая сортирует массив от большего к меньшему и находит медианное значение. Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры.

using System;

namespace HomeWork
{
    class TaskFour
    {
        static void Main()
        {
            var newArr = ShowArray();
            System.Console.WriteLine("Get array: ");
            PrintArray(newArr);
            System.Console.WriteLine("Array is after sorting: ");
            newArr = SortArray(newArr);
            PrintArray(newArr);
            double medianValue = (newArr.Length%2 != 0) ? newArr[newArr.Length/2] : ((double)(newArr[newArr.Length/2] + newArr[newArr.Length/2 - 1])/2);
            System.Console.WriteLine($"Median value is equal: {medianValue}");
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
            for (int i = 0; i < size; i++) arr[i] = new Random().Next(1, 100);
            return arr;        
        }
        static int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int indMin = i;
                for (int j = i + 1; j < array.Length; j++) if (array[j] < array[indMin]) indMin = j;
                if (indMin != i)
                {
                    int tmp = array[i];
                    array[i] = array[indMin];
                    array[indMin] = tmp;
                }
            }
            return array;
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i!=arr.Length - 1) System.Console.Write($"{arr[i]}, ");
                else System.Console.Write($"{arr[i]}\n");
            }
        }
    }
}