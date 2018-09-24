using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAula6
{
    class Exe2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De quantas pessoas vc quer ler o salario?");
            int qtdPessoas = int.Parse(Console.ReadLine());
            var pessoas = new Pessoa[qtdPessoas];

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine("Digite o salário da pessoa número " + (i + 1));
                var pessoa = new Pessoa { Salario = decimal.Parse(Console.ReadLine()) };

                pessoas[i] = pessoa;
            }

            var soma = 0M;
            for (int i = 0; i < pessoas.Length; i++)
            {
                soma += pessoas[i].Salario;
            }

            Console.WriteLine("A soma total de salarios é:" + soma);
            Console.ReadLine();
        }
    }
}
