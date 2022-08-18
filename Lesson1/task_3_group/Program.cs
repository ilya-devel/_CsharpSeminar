using System;

namespace taskThree
{
    class Task 
    {
        static void Main()
        {
            string[] week = new string[7] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"}; 
            Console.WriteLine("Введите от 1 до 7: ");
            int day = Convert.ToInt32(Console.ReadLine());
            if ((day > 0) &&  (day < 8))
            {
                Console.WriteLine("Вы указали :" + week[day-1]);
            }
            else
            {
                Console.WriteLine("Число не соответствует запросу");
            }
            
        }
    }
}