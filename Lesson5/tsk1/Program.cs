// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

using System;
using System.Collections.Generic;

namespace LessonFive
{
    class TaskOne
    {
        static void Main()
        {
            var arr = GetArray();
            System.Console.WriteLine("\nGet array: ");
            foreach (var item in arr) System.Console.Write($"{item} ");
            System.Console.WriteLine("\n");
            var summary = GetSummaryValues(arr);
            System.Console.WriteLine($"Negative equal: {summary["Negative"]}; Positive equal: {summary["Positive"]}");
        }
        static int[] GetArray()
        {
            System.Console.WriteLine("Enter size of array: ");
            int size = Convert.ToInt32(System.Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++) array[i] = new Random().Next(-9, 9); 
            return array;
        }
        static Dictionary<string, int> GetSummaryValues(int[] array)
        {
            var summaryValues = new Dictionary<string, int> ();
            int sumNegative = 0, sumPositive = 0;
            foreach (var item in array)
            { 
                if (item > 0) sumPositive += item;
                else sumNegative += item;
            }
            summaryValues.Add("Positive", sumPositive);
            summaryValues.Add("Negative", sumNegative);
            return summaryValues;
        }
    }
}