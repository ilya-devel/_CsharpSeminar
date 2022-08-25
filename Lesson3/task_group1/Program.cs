// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

using System;

namespace TaskGroup
{
    class TaskGroupOne
    {
        static void Main()
        {
            int place = -1;
            try
            {
                place = GetPlace();
            }
            catch
            {
                System.Console.WriteLine("You need enter positive integer number from 1 to 4!!!");
            }
            ShowDiap(place);
        }
        static int GetPlace()
        {
            System.Console.WriteLine("Enter num place from 1 to 4:");
            int place = Convert.ToInt32(Console.ReadLine());
            return place;
        }
        static void ShowDiap (int place)
        {
            if (place != -1)
            {
            if (place == 1) System.Console.WriteLine("x > 0 && y > 0");
            else if (place == 2) System.Console.WriteLine("x > 0 && y < 0");
            else if (place == 3) System.Console.WriteLine("x < 0 && y < 0");
            else System.Console.WriteLine("x < 0 && y > 0");
            }
            else System.Console.WriteLine("Invalid number");
        }
    }
}