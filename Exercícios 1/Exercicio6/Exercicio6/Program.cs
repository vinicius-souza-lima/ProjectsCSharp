using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(" ");
            double A = double.Parse(input[0],CultureInfo.InvariantCulture);
            double B = double.Parse(input[1],CultureInfo.InvariantCulture);
            double C = double.Parse(input[2],CultureInfo.InvariantCulture);

            Shape shapes = new(A, B, C);
            Console.WriteLine("TRIANGULO: " + shapes.AreaTri().ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + shapes.AreaCirc().ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + shapes.AreaTrap().ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + shapes.AreaQuad().ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + shapes.AreaRet().ToString("F3", CultureInfo.InvariantCulture));
        }
    }

    class Shape {
        private double A;
        private double B;
        private double C;
        private const double pi = 3.14159;

        public Shape(double A, double B, double C) { 
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public double AreaTri() => A * C / 2.0;
        public double AreaCirc() => pi * C * C;
        public double AreaTrap() => (A + B) * C / 2.0;
        public double AreaQuad() => B * B;
        public double AreaRet() => A * B;
    }
}