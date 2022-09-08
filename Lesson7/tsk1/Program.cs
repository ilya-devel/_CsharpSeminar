using System;

namespace LessonSeven
{
    class ExampleOne
    {
        static void Main()
        {
            string[] keys = new string[] {"row", "col"};
            
        }
        static int GetSizeValues(string key = "элементов")
        {
            System.Console.WriteLine($"Введите количество {key}: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int values);
            if (!check)
            {
                System.Console.WriteLine("Не верно указаны данные, принята величина по умолчанию (3)!");
                values = 3;
            }
            return values;
        }
    }
}