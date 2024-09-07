using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string[] vec1 = Console.ReadLine().Split(" ");
            string[] vec2 = Console.ReadLine().Split(" ");

            Console.WriteLine("VALOR A PAGAR: R$ " + (float.Parse(vec1[1],CultureInfo.InvariantCulture) *
                                                      float.Parse(vec1[2],CultureInfo.InvariantCulture) +
                                                      float.Parse(vec2[1],CultureInfo.InvariantCulture) *
                                                      float.Parse(vec2[2],CultureInfo.InvariantCulture)).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}