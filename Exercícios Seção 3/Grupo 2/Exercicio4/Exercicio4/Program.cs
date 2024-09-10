using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(" ");
            int hora1 = int.Parse(input[0]);
            int hora2 = int.Parse(input[1]);

            int duracao = 24 - hora1 + hora2;

            if (duracao > 24)
                duracao -= 24;

            Console.WriteLine("O JOGO DUROU " + duracao + " HORAS(S)");
        }
    }
}