// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

using System;

namespace hw_tsk1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                var getAns = GetQuest();
                if(getAns is Int32 && (int)getAns > 0) count++;
                if(getAns is string && (string)getAns == "exit") break;
            }
            System.Console.WriteLine($"Пользователь ввёл {count} положительных чисел");
        }
        static object GetQuest()
        {
            System.Console.WriteLine($"Введите число, для выхода введите exit: ");
            string ans = Console.ReadLine();
            if (ans.ToLower() == "exit") return ans;
            else
            {
                bool check = Int32.TryParse(ans, out int num);
                if (!check)
                {
                    System.Console.WriteLine("Не верное число, принято число по умолчанию (0): ");
                    num = 0;
                }
                return num;
            }
        }
    }
}
