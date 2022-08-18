using System;

namespace taskOne
{
    class Task 
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Ноль и в Африке ноль");
            }
            else
            {
                Console.WriteLine(num*num);
            }
        }
    }
}