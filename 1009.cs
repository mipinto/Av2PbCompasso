using System;

namespace Q1_1009
{
    class Program
    {
        static void Main(string[] args) {

            string nomeVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double montante = double.Parse(Console.ReadLine());

            double salarioTotal = montante * 0.15 + salarioFixo;

            Console.WriteLine($"TOTAL = R$ {salarioTotal:F2}");

        }

    }
}
    }
}
