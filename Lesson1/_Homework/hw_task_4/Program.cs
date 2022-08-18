using System;

namespace hwFour
{
    class HomeWork
    {
        static void Main()
        {
            Console.WriteLine("Enter positive integer number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0) Console.WriteLine("You entered zero!");
            if (num < 0)
            {
                Console.WriteLine("You entered a negative number, we fixed it");
                num = num * -1;
            }
            int i = 2;
            while (i <= num)
            {
                if (i+2 > num) Console.Write(i);
                else Console.Write(i + ", ");
                i += 2;
            }
            Console.Write("\n");
        }
    }
}