using System;

namespace TaskTwoGroup
{
    class Task
    {
        static void Main()
        {
            int numOne = new Random().Next(1, 100);
            int numTwo = new Random().Next(1, 10);
            System.Console.WriteLine(CheckNumbers(numOne, numTwo));
        }
        static string CheckNumbers(int num1, int num2)
        {
            if (num1 % num2 == 0) return $"Первое число {num1} кратно второму числу {num2}";
            else return $"Первое число {num1} не кратно второму числу {num2} и остаток равен {num1%num2}";
        }
    }
}