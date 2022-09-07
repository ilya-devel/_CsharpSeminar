// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
// Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно переместился на другое место
// (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций.
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

using System;
using System.Collections.Generic;

namespace hw_tsk4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = GetRowAndColForTable();
            int[,]  matrix = new int[size[0], size[1]] ;
            System.Console.WriteLine();
            matrix = Fill2DMatrix(matrix);
            ShowMatrix(matrix);
            System.Console.WriteLine();
            int[,] mixMatrix = GetMixValuesIn2DMatrix(matrix);
            ShowMatrix(mixMatrix);
            System.Console.WriteLine();
        }
        static int[,] Fill2DMatrix(int[,] matrix)
        {
            int maxValue = (matrix.GetLength(0) * matrix.GetLength(1));
            for(int i=0; i < matrix.GetLength(0); i++) 
            for (int j=0; j < matrix.GetLength(1); j++) matrix[i,j] = new Random().Next(1, maxValue);
            return matrix;
        }
        static int[] GetRowAndColForTable()
        {
            int[] rowCol = new int[2];
            string[] headers = new string[] {"строк", "столбцов"};
            for (int i=0; i < rowCol.Length;i++)
            {
                System.Console.WriteLine($"Введите количество {headers[i]}: ");
                bool check = int.TryParse(Console.ReadLine(), out int length);
                if (!check)
                {
                    System.Console.WriteLine("Не верные данные принята величина по умолчанию (2)");
                    length = 2;
                }
                rowCol[i] = length;
            }
            return rowCol;
        }
        static void ShowMatrix(int[,] matr)
        {
            for(int i=0; i < matr.GetLength(0); i++)
                {
                    for (int j=0; j < matr.GetLength(1); j++) System.Console.Write($"{matr[i,j]:d2} ");
                    System.Console.WriteLine();
                }
        }
        static List<int> GetListValues(int[,] matrix)
        {
            var listValues = new List<int>();
            for(int i=0; i < matrix.GetLength(0); i++) 
            for (int j=0; j < matrix.GetLength(1); j++) listValues.Add(matrix[i,j]);
            return listValues;
        }
        static int[,] GetMixValuesIn2DMatrix(int[,] matrix)
        {
            int[,] mixMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
            var listValues = GetListValues(matrix);
            for(int i=0; i < matrix.GetLength(0); i++) 
            for (int j=0; j < matrix.GetLength(1); j++) 
            {
                int count = 0;
                do
                {
                    int index = new Random().Next(0, listValues.Count);
                    if(listValues[index] != matrix[i,j])
                    {
                        mixMatrix[i,j] = listValues[index];
                        listValues.RemoveAt(index);
                        break;
                    }
                } while (count != (matrix.GetLength(0) * matrix.GetLength(1)));
                if (count == (matrix.GetLength(0) * matrix.GetLength(1))) return GetMixValuesIn2DMatrix(matrix);
            }
            return mixMatrix;
        }
    }
}
