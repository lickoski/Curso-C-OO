using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes;
            nomes = new string[4];

            nomes[0] = "Tiago";
            nomes[1] = "Grabriel";
            nomes[2] = "Mauricio";
            nomes[3] = "Camilla";

            //Acessando a posição 2 do array
            var nome = nomes[2];
            Console.WriteLine(nome);

            Console.ReadLine();
        }
    }
}
