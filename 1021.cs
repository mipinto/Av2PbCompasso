//Wrong answer(100%)

using System;


namespace Q7_1021
{

    static void Main(string[] args) {


        double N;
        int n100, n50, n20, n10, n5, n2, m100, m50, m25, m10, m5, m1, resto;

        N = double.Parse(Console.ReadLine());

        resto = (int)N;

        Console.WriteLine("NOTAS:");

        n100 = resto / 10000;

        Console.WriteLine(n100 + " nota(s) de R$ 100.00");

        resto = resto % 10000;
        n50 = resto / 5000;

        Console.WriteLine(n50 + " nota(s) de R$ 50.00");

        resto = resto % 5000;
        n20 = resto / 2000;

        Console.WriteLine(n20 + " nota(s) de R$ 20.00");

        resto = resto % 2000;
        n10 = resto / 1000;

        Console.WriteLine(n10 + " nota(s) de R$ 10.00");

        resto = resto % 1000;
        n5 = resto / 500;

        Console.WriteLine(n5 + " nota(s) de R$ 5.00");

        resto = resto % 500;
        n2 = resto / 200;

        Console.WriteLine(n2 + " nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");

        resto = resto % 200;
        m100 = resto / 100;

        Console.WriteLine(m100 + " moeda(s) de R$ 1.00");

        resto = resto % 100;
        m50 = resto / 50;

        Console.WriteLine(m50 + " moeda(s) de R$ 0.50");

        resto = resto % 50;
        m25 = resto / 25;

        Console.WriteLine(m25 + " moeda(s) de R$ 0.25");

        resto = resto % 25;
        m10 = resto / 10;

        Console.WriteLine(m10 + " moeda(s) de R$ 0.10");

        resto = resto % 10;
        m5 = resto / 5;

        Console.WriteLine(m5 + " moeda(s) de R$ 0.05");

        resto = resto % 5;
        m1 = resto;

        Console.WriteLine(m1 + " moeda(s) de R$ 0.01");

       
    }

}
