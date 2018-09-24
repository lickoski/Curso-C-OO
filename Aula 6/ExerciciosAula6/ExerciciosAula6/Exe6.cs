using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAula6
{
    class Exe6
    {
        static void Main(string[] args)
        {
            //const int nome = 0;
            //const int idade = 1;

            var pessoas = new Pessoa[10];
            int menorIdade = 0;

            for (int i = 0; i < pessoas.Length; i++)
            {
                var pessoa = new Pessoa();

                Console.WriteLine("Digite o nome da pessoa numero " + (i + 1));
                pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Digite a idade da pessoa numero " + (i + 1));
                pessoa.Idade = int.Parse(Console.ReadLine());

                if (pessoa.Idade < menorIdade || i == 0)
                {
                    menorIdade = pessoa.Idade;
                }

                pessoas[i] = pessoa;

            }

            for (int i = 0; i < pessoas.Length; i++)
            {
                if (pessoas[i].Idade < 18)
                {
                    Console.WriteLine(pessoas[i].Nome + " é menor de 18 anos!");
                }
            }

            Console.WriteLine("A menor idade encontrada é :" + menorIdade);

            Console.ReadLine();
        }
    }
}
