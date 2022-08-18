using System;

namespace taskTwo
{
    class Task 
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2*num2)
            {
                Console.WriteLine("Первое число квадрат второго");
            }
            else if (num1*num1 == num2)
            {
                Console.WriteLine("Второе число квадрат первого");
            }
            else
            {
                Console.WriteLine("Ниодно число не является квадратом другого");
            }
        }
    }
}