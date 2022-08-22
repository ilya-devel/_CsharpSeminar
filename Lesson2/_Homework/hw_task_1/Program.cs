// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;

namespace HomeWorkOne
{
    class HomeWork
    {
        static void Main()
        {
            int maxSize = 10000;
            int rndNum = new Random().Next(1, maxSize);
            System.Console.WriteLine($"Get number: {rndNum}");
            System.Console.WriteLine($"Second digit equal: {GetDigitFromNumber(rndNum)}");
            System.Console.WriteLine($"Do you want to get another number if yes so what? Enter number from 1 until {Convert.ToString(maxSize-1).Length} or 'n'");
            string getAnswer = Console.ReadLine();
            int getNumFromAns = -1;
            if (int.TryParse(getAnswer, out getNumFromAns))
                {
                    System.Console.WriteLine($"{getNumFromAns}-th equal {GetDigitFromNumber(rndNum, getNumFromAns)}");
                }

        }
        static int GetDigitFromNumber(int mainNumber, int getNum = 2)
        {
            return (int)(mainNumber % Math.Pow(10, getNum) / (double)Math.Pow(10, getNum - 1));
        }

    }
}