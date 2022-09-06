// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

using System;

namespace tsk_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] triagleSideLength = GetUserNum(3);
            CheckCreateTriangle(triagleSideLength);
        }
        
        static int[] GetUserNum(int size)
        {
            int[] triangleSide = new int[size];
            for (int i=0; i < size; i++)
            {
                System.Console.WriteLine($"Введите {i+1}-сторону треугольника");
                bool check = Int32.TryParse(Console.ReadLine(), out int length);
                if (!check)
                {
                    System.Console.WriteLine("Не верная длина, принята длина по умолчанию (1)");
                    length = 1;
                }
                triangleSide[i] = length;
            }
            return triangleSide;
        }
        
        static void CheckCreateTriangle(int[] lengthSide)
        {
            if (lengthSide[0] < lengthSide[1] + lengthSide[2] &&
            lengthSide[1] < lengthSide[0] + lengthSide[2] &&
            lengthSide[2] < lengthSide[1] + lengthSide[0])
            {
                System.Console.WriteLine("Такой треугольник может существовать!");
            }
            else
            {
                System.Console.WriteLine("Такой треугольник НЕ может существовать!");
            }
        }
    }
}
