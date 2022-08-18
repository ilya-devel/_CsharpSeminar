using System;

namespace hwOne
{
    class HomeWork
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2) 
            {
                Console.WriteLine("Первое число больше второго: max=" + num1);
            }
            else if (num2 > num1) 
            {
                Console.WriteLine("Второе число больше первого: max=" + num2);
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
        }
    }
}