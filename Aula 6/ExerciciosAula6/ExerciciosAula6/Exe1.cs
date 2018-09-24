using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAula6
{
    class Exe1
    {
        static void Main(string[] args)
        {
            var pessoas = new Pessoa[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o nome da pessoa!");
                var pessoa = new Pessoa { Nome = Console.ReadLine()};

                pessoas[i] = pessoa;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(pessoas[i].Nome);
            }

            Console.ReadLine();
        }
    }
}
