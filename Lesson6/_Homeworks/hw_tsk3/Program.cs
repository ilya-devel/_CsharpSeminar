// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа.
// Определить , является ли это сторонами треугольника.
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

using System;

namespace hw_tsk3
{
    class Program
    {
        static void Main(string[] args)
        {
            // double tmp = (((double)3*3)+(7*7)-(5*5))/(2*(3*7));
            // double tmp2 = (Math.Acos(tmp) * 180) / Math.PI;
            // System.Console.WriteLine($"{tmp} : {tmp2}");
            Triangle trg = new Triangle(GetLengthSides());
            trg.ShowInfo();
            
        }
        static double[] GetLengthSides()
        {
            double[] side = new double[3];
            for (int i = 0; i<side.Length; i++)
            {
                System.Console.WriteLine($"Введите {i+1} сторону треугольника: ");
                bool check = Double.TryParse(Console.ReadLine(), out double length);
                if (!check)
                {
                    System.Console.WriteLine("Не верная длина, принят размер по умолчанию (1)!");
                    length = 1;
                }
                side[i] = length;
            }
            return side;
        }
    }
}
