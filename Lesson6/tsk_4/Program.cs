// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

using System;

namespace tsk_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = GetUserNum();
            System.Console.WriteLine($"Первые {size} чисел списка Фиббоначи равны:");
            ShowArray(GetArrayFib(size));
        }
        static int GetUserNum()
        {
            System.Console.WriteLine($"Введите количество цифр для демонстрации в списке Фиббоначи: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int num);
            if (!check)
            {
                System.Console.WriteLine("Не верное число, принято число по умолчанию (3): ");
                num = 3;
            }
            return num;
        }
        static int[] GetArrayFib(int size)
        {
            int[] arr = new int[size];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < size; i++) arr[i] = arr[i-1] + arr[i-2];
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
    }
}
