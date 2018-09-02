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
            Console.WriteLine("Digite sua alíquota de imposto de renda:");

            var aliquota = decimal.Parse(Console.ReadLine());

            switch (aliquota)
            {
                case 7.5M:
                    Console.WriteLine("Pobre");
                    break;

                case 15M:
                    Console.WriteLine("Pouco Pobre");
                    break;

                case 22.5M:
                    Console.WriteLine("Sobrevive");
                    break;

                case 27.5M:
                    Console.WriteLine("Rico!");
                    break;

                default:
                    Console.WriteLine("Aliquota nao encontrada!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
