using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    class Program
    {
        static void Main(string[] args){

            
            int tempo = int.Parse(Console.ReadLine());

            int horas = (tempo / 3600);
            int minutos = (tempo % 3600) / 60;
            int segundos = (tempo % 3600) % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");

        }
    }
}
