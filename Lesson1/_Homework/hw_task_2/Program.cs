using System;

namespace hwTwo
{
    class HomeWork
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max = num1;
            if (max < num2) max = num2;
            if (max < num3) max = num3;

            Console.WriteLine("Maximal number equal: " + max);
        }
    }
}