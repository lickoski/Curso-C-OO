using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAula6
{
    class Exe4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("De quantas pessoas vc quer ler o nome?");
            int qtdPessoas = int.Parse(Console.ReadLine());
            var pessoas = new Pessoa[qtdPessoas];

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine("Digite o nome da pessoa numero " + (i + 1));
                var pessoa = new Pessoa { Nome = Console.ReadLine() };

                pessoas[i] = pessoa;
            }

            var pessoasComCinco = new Pessoa[5];

            for (int i = 0; i < 5; i++)
            {
                pessoasComCinco[i] = pessoas[i];
            }

            for (int i = 0; i < pessoasComCinco.Length; i++)
            {
                Console.WriteLine("Pessoa numero " + (i + 1) + ": " + pessoasComCinco[i].Nome);
            }


            Console.ReadLine();

        }
    }
}
