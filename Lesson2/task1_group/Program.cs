using System;

namespace TaskOneGroup
{
    class Task
    {
        static void Main()
        {
            EditRandomNumberForSecondNumber();
            System.Console.WriteLine("Enter number: ");
            RemoveSecondNumber(Convert.ToInt32(Console.ReadLine()));
        }
        static void RemoveSecondNumber(int numMain)
        {
            int num1 = numMain/100*10;
            int num2 = numMain%10;

            System.Console.WriteLine($"We got number: {numMain}");
            System.Console.WriteLine($"num: {num1 + num2}");
        }
        static void EditRandomNumberForSecondNumber()
        {
            int rndNum = new Random().Next(100, 1000);
            int num1 = rndNum/100*10;
            int num2 = rndNum%10;

            System.Console.WriteLine($"generate num: {rndNum}");
            System.Console.WriteLine($"num: {num1 + num2}");
        }
    }
}