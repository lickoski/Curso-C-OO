using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAula6
{
    class Exe3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De quantas pessoas vc quer ler a idade?");
            int qtdPessoas = int.Parse(Console.ReadLine());
            var pessoas = new Pessoa[qtdPessoas];

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine("Digite a idade da pessoa número " + (i + 1));
                var pessoa = new Pessoa { Idade = int.Parse(Console.ReadLine()) };

                pessoas[i] = pessoa;
            }

            for (int i = 0; i < pessoas.Length; i++)
            {
                if (pessoas[i].Idade > 18)
                    Console.WriteLine(pessoas[i].Idade);
            }

            Console.ReadLine();
        }
    }
}
