// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21 

namespace LessonFive
{
    class GroupTaskFour
    {
        static void Main()
        {
            var arr = GetArray();
            System.Console.WriteLine("Получен массив: ");
            foreach (var num in arr) System.Console.Write($"{num} ");
            System.Console.WriteLine("\n");
            System.Console.WriteLine("Массив сумм пар с концов массива: ");
            foreach (var item in PairSummary(arr)) System.Console.Write($"{item} ");
            System.Console.WriteLine("\n");
        }
        static int[] GetArray()
        {
            System.Console.WriteLine("Введите размер массива: ");
            int size;
            bool checking = Int32.TryParse(Console.ReadLine(), out size);
            if (!checking)
            {
                System.Console.WriteLine("Не верный размер, принят размер по умолчанию (10)");
                size = 10;
            }
            int[] array = new int[size];
            for (int i = 0; i < size; i++) array[i] = new Random().Next(-9, 9);
            return array;
        }
        static int[] PairSummary(int[] array)
        {
            // int size = ((array.Length%2)==0)? array.Length/2 : (array.Length/2)+1;
            int size = array.Length / 2 + (array.Length % 2);
            int[] sumPairArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                if (i != (array.Length - (i + 1))) sumPairArray[i] = array[i] * array[array.Length - (i + 1)];
                else sumPairArray[i] = array[i];
            }
            return sumPairArray;
        }
    }
}