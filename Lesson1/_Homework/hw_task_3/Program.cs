using System;

namespace hwThree
{
    class HomeWork
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0) Console.WriteLine("You entered zero");
            else if (num % 2 == 0) Console.WriteLine("Number is even");
            else Console.WriteLine("Number odd");
        }
    }
}