using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double x = Program.Circunferencia(raio);
            Console.WriteLine(x,"F2",CultureInfo.InvariantCulture);
        }

        static public double Circunferencia(double raio) {
            double pi = 3.14159;
            return pi * raio * raio;
        }
    }
}