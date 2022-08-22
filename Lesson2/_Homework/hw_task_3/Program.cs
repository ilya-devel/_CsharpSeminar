using System;
using System.Collections.Generic;

namespace HomeWorkThree
{
    class HomeWork
    {
        static void Main()
        {
            System.Console.WriteLine("Enter number day of weekday: ");
            int num = Convert.ToInt32(System.Console.ReadLine());
            // Console.WriteLine(HardWeekDay(num));
            Console.WriteLine(VeryLongWeekDay(num));
        }
        static string VeryLongWeekDay(int numWDay)
        {
            
            string dayOff = (numWDay == 6 || numWDay == 7) ? "It is day off" : "It isn't day off";

            if (numWDay == 1) return $"Monday. {dayOff}";
            else if (numWDay == 2) return $"Tuesday. {dayOff}";
            else if (numWDay == 3) return $"Wednesday. {dayOff}";
            else if (numWDay == 4) return $"Thursday. {dayOff}";
            else if (numWDay == 5) return $"Friday. {dayOff}";
            else if (numWDay == 6) return $"Saturday. {dayOff}";
            else if (numWDay == 7) return $"Sunday. {dayOff}";
            else return "it is not weekday!";
        }
        static string HardWeekDay(int numWDay)
        {
            var weekdays = new Dictionary<int, string>() {
                {1, "Monday"},
                {2, "Tuesday"},
                {3, "Wednesday"},
                {4, "Thursday"},
                {5, "Friday"},
                {6, "Saturday"},
                {7, "Sunday"}
            };
            
            string dayOff = (numWDay == 6 || numWDay == 7) ? "It is day off" : "It isn't day off";

            if (numWDay > 0 && numWDay < 8)
            {
                return $"{weekdays[numWDay]}. {dayOff}";
            }
            else
            {
                return "it is not weekday!";
            }
        }
    }
}