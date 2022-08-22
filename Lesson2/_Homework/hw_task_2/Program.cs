// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;

namespace HomeWorkOne
{
    class HomeWork
    {
        static void Main()
        {
            int maxSize = 1000;
            int rndNum = new Random().Next(1, maxSize);
            System.Console.WriteLine($"Get number: {rndNum}");
            int ans = GetDigitFromNumber(rndNum);
            
            if (ans != -1)
                System.Console.WriteLine($"Third digit equal: {ans}");
            else
                System.Console.WriteLine($"Sorry, there is not third digit in this number: {rndNum}");
            
        }
        static int GetDigitFromNumber(int mainNumber, int getNum = 3)
        {
            if (mainNumber > 100)
            {
                return (int)(mainNumber % Math.Pow(10, getNum) / (double)Math.Pow(10, getNum - 1));
            }
            else
            {
                return -1;
            }

        }

    }
}