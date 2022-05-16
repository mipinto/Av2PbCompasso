using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Q4_1018
{
    class Program
    {

        static void Main(string[] args) {

            CultureInfo culture = new CultureInfo("pt-BR");

            int valor = 0;
            int[] valores = new int[] { 100, 50, 20, 10, 5, 2, 1 };
            int[] cedulas = new int[7];

            int.TryParse(Console.ReadLine(), out valor);
            int _valor = valor;
            for (int i = 0; i < valores.Length; i++) {
                if ((_valor / valores[i]) > 0) {
                    cedulas[i] = (_valor / valores[i]);
                    _valor = _valor % valores[i];
                } else {
                    cedulas[i] = 0;
                }
            }

            Console.WriteLine(String.Format("{0}", valor));
            for (int i = 0; i < valores.Length; i++) {
                Console.WriteLine(String.Format("{0} nota(s) de R$ {1}", cedulas[i], (double.Parse(valores[i].ToString())).ToString("F2", culture)));
            }
        }

    }
}

