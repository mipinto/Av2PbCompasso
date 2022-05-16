using System;

namespace Q2_1010
{
    class Program
    {
        static void Main(string[] args) {

            int codigo_P1, codigo_P2, quantidade_P1, quantidade_P2;
            double valorUnitario_P1, valorUnitario_P2, valorAPagar;

            Console.WriteLine("Código P1: ");
            codigo_P1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade P1: ");
            quantidade_P1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor unitário P1: ");
            valorUnitario_P1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Código P2: ");
            codigo_P2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade P2: ");
            quantidade_P2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor unitário P2: ");
            valorUnitario_P2 = double.Parse(Console.ReadLine());
            
            valorAPagar = (valorUnitario_P1 * quantidade_P1) + (valorUnitario_P2 * quantidade_P2);

            Console.WriteLine("Valor total a ser pago: R$ {0:f2}", valorAPagar);
            Console.ReadKey();
        }
    }
}
