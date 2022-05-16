
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_1020
{
    class Program
    {
        static void Main(string[] args) {
           

                int idade_dias = int.Parse(Console.ReadLine());

                int ano = idade_dias / 365;
                int mes = idade_dias % 365 / 30;
                int dia = (idade_dias % 365) % 30;

                Console.Write("{0} ano(s)\n{1} mes(es)\n{2} dia(s)\n", ano, mes, dia);

        }
    }
}
    

