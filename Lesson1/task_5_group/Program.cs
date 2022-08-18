using System;

namespace taskFive
{
    class Task
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int start = num * -1;
            while (start <= num) 
            {
                Console.Write(start + ", ");
                start++;
            }
            Console.WriteLine("\n");
        }
    }
}