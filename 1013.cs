using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q3_1013
{
    class Program
    {
        static void Main(string[] args) {

            int A, B, C, maiorAB, maiorABC; 
     
            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            

            maiorAB = (A + B + Math.Abs(A - B)) / 2;
            maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine(maiorABC + " eh o maior");


        }
    }
}
