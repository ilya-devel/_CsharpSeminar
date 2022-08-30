// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using System;

namespace HomeWork
{
    class TaskOne
    {
        static void Main(string[] args)
        {
            ShowPowVersionOne();
        }
        static void ShowPowVersionOne()
        {
            char[] numbers = {'A', 'B'};
            int[] values = new int[2];

            for (int i = 0; i < values.Length; i++)
            {
                System.Console.WriteLine($"Enter value of number {numbers[i]}: ");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine($"Value of number {numbers[0]} to exponent {numbers[1]} equal {Math.Pow(values[0], values[1])}");
        }
    }
}