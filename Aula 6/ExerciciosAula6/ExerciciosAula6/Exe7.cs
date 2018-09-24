using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAula6
{
    class Exe7
    {
        static void Main(string[] args)
        {
            //const int codigo = 0;
            //const int descricao = 1;
            //const int valor = 2;

            var opcao = "";
            var produtos = new Produto[100];

            int indiceVetor = 0;

            while (opcao != "0")
            {
                Console.Clear();
                Console.WriteLine("Digite a opção desejada: \n 1 - Incluir Produto \n 2 - Alterar Produto \n 3 - Consultar Produto \n 4 - Imprimir Todos \n 0 - Sair do Sistema");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        var produto = new Produto();

                        Console.Clear();
                        Console.WriteLine("Você está incluindo um produto!");

                        //Recebe a codigo do produto digitada pelo usuario
                        Console.WriteLine("Código:");
                        produto.Codigo = int.Parse(Console.ReadLine());

                        //Recebe a descrição do produto digitada pelo usuario
                        Console.WriteLine("Descrição:");
                        produto.Descricao = Console.ReadLine();

                        //Recebe o valor do produto digitada pelo usuario
                        Console.WriteLine("Valor:");
                        produto.Valor = decimal.Parse(Console.ReadLine());


                        produtos[indiceVetor] = produto;

                        //Incrementa o indice do vetor para saber onde será incluido o próximo
                        indiceVetor += 1;

                        Console.WriteLine("Produto cadastrado com sucesso! Pressione qualquer tecla para continuar...");
                        Console.ReadLine();
                        break;


                    case "2":

                        Console.Clear();
                        Console.WriteLine("Você está alterando um produto!");
                        Console.WriteLine("Digite o código do produto que deseja alterar:");
                        var codigoAlteracao = int.Parse(Console.ReadLine());
                        for (int i = 0; i < indiceVetor; i++)
                        {
                            if (produtos[i].Codigo == codigoAlteracao)
                            {
                                Console.WriteLine("Digite a nova descrição:");
                                produtos[i].Descricao = Console.ReadLine();

                                Console.WriteLine("Digite o novo valor:");
                                produtos[i].Valor = decimal.Parse(Console.ReadLine());

                                Console.WriteLine("Produto alterado com sucesso!Pressione qualquer tecla para continuar...");

                                Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Você está consultando um produto!");
                        Console.WriteLine("Digite o código do produto que deseja consultar:");
                        var codigoConsulta = int.Parse(Console.ReadLine());

                        for (int i = 0; i < indiceVetor; i++)
                        {
                            if (produtos[i].Codigo == codigoConsulta)
                            {
                                Console.Clear();
                                Console.WriteLine("Produto encontrado");
                                Console.WriteLine("Codigo: " + produtos[i].Codigo);
                                Console.WriteLine("Descricao: " + produtos[i].Descricao);
                                Console.WriteLine("Valor: " + produtos[i].Valor);
                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadLine();
                                break;
                            }
                            
                        }

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Imprimindo todos os produtos \n \n");
                        for (int i = 0; i < indiceVetor; i++)
                        {
                            Console.WriteLine(produtos[i].Codigo + " | " + produtos[i].Descricao + " | " + produtos[i].Valor + " | ");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadLine();
                        break;

                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Você saiu do sistema");
            Console.ReadLine();

        }
    }
}
