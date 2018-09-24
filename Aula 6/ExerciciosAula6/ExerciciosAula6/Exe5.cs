using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAula6
{
    class Exe5
    {
        static void Main(string[] args)
        {

            //const int nome = 0;
            //const int cidade = 1;
            //const int bairro = 2;
            //const int estado = 3;

            Console.WriteLine("De quantos clientes você quer ler os dados?");
            int qtdPessoas = int.Parse(Console.ReadLine());
            var pessoas = new Pessoa[qtdPessoas];

            for (int i = 0; i < pessoas.Length; i++)
            {
                var pessoa = new Pessoa();

                Console.WriteLine("Digite o nome da pessoa numero " + (i + 1));
                pessoa.Nome = Console.ReadLine();

                Console.WriteLine("Digite o cidade da pessoa numero " + (i + 1));
                pessoa.Cidade = Console.ReadLine();

                Console.WriteLine("Digite o bairro da pessoa numero " + (i + 1));
                pessoa.Bairro = Console.ReadLine();

                Console.WriteLine("Digite o estado da pessoa numero " + (i + 1));
                pessoa.Estado = Console.ReadLine();


                pessoas[i] = pessoa;
            }

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine(pessoas[i].Nome + " | " + pessoas[i].Cidade + " | " + pessoas[i].Bairro + " | " + pessoas[i].Estado);
            }


            Console.ReadLine();

        }
    }
}
