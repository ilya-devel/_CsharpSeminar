using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_tsk3
{
    public class Triangle
    {
        public double AB { get; private set; }
        public double BC { get; private set; }
        public double CA { get; private set; }
        private static double Q(double x) => x*x;
        public Triangle() : this(1, 1, 1) { }
        public Triangle(int ab, int bc, int ca)
        {
            double[] arr = { ab, bc, ca };
            if (Triangle.CanMakeThisTriangle(arr))
            {
                AB = ab;
                BC = bc;
                CA = ca;
            }
            else System.Console.WriteLine("Не верные размеры сторон!");
        }
        public Triangle(double ab, double bc, double ca)
        {
            double[] arr = { ab, bc, ca };
            if (Triangle.CanMakeThisTriangle(arr))
            {
                AB = ab;
                BC = bc;
                CA = ca;
            }
            else System.Console.WriteLine("Не верные размеры сторон!");
        }
        public Triangle(double[] arr)
        {
            if (Triangle.CanMakeThisTriangle(arr))
            {
                AB = arr[0];
                BC = arr[1];
                CA = arr[2];
            }
            else System.Console.WriteLine("Не верные размеры сторон!");
        }

        static bool CanMakeThisTriangle(double[] lengthSide)
        {
            if (lengthSide[0] < lengthSide[1] + lengthSide[2] &&
            lengthSide[1] < lengthSide[0] + lengthSide[2] &&
            lengthSide[2] < lengthSide[1] + lengthSide[0])
            {
                System.Console.WriteLine("Такой треугольник может существовать!");
                return true;
            }
            else
            {
                System.Console.WriteLine("Такой треугольник НЕ может существовать!");
                return false;
            }
        }
        public double GetSquareTriangle()
        {
            double p = (this.AB + this.BC + this.CA) / 2;
            return Math.Sqrt(p * (p - this.AB) * (p - this.BC) * (p - this.CA));
        }
        public void ShowValuesCorners()
        {
            // System.Console.WriteLine($"Угол alpha (AB-CA)треугольника равен: {Math.Acos((Q(this.AB) + Q(this.CA) - Q(this.BC)) / (2 * this.AB * this.CA)) * 180 / Math.PI}");
            System.Console.WriteLine($"Угол Alpha (AB-CA)треугольника равен: {this.Alpha()}");
            System.Console.WriteLine($"Угол Beta (AB-BC)треугольника равен: {this.Beta()}");
            System.Console.WriteLine($"Угол Gamma (BC-CA)треугольника равен: {this.Gamma()}");
        }
        public string WhatIsItType()
        {
            if (this.AB == this.BC && this.BC == this.CA && this.CA == this.AB) return "равносторонний";
            else if (this.AB == this.BC || this.BC == this.CA || this.CA == this.AB) return "равнобедренный";
            else if (this.Alpha() == 90 || this.Beta() == 90 || this.Gamma() == 90) return "прямоугольный";
            else return "не типичный";
        }
        public double Alpha() => (Math.Acos((Q(this.AB) + Q(this.CA) - Q(this.BC)) / (2 * this.AB * this.CA)) * 180 / Math.PI);
        public double Beta() => (Math.Acos((Q(this.AB) + Q(this.BC) - Q(this.CA)) / (2 * this.AB * this.BC)) * 180 / Math.PI);
        public double Gamma() => (Math.Acos((Q(this.BC) + Q(this.CA) - Q(this.AB)) / (2 * this.BC * this.CA)) * 180 / Math.PI);
        public void ShowInfo()
        {
            if (AB != 0 && BC != 0 && CA != 0)
            {
                System.Console.WriteLine($"Стороны треугольника равны: AB = {AB}, BC = {BC}, CA = {CA}");
                System.Console.WriteLine($"Площадь треугольника равна: {this.GetSquareTriangle()}");
                System.Console.WriteLine($"Периметр треугольника равен: {this.AB + this.BC + this.CA}");
                System.Console.WriteLine();
                this.ShowValuesCorners();
                System.Console.WriteLine();
                System.Console.WriteLine($"Данный треугольник - {this.WhatIsItType()}");
            }
        }
    }
}