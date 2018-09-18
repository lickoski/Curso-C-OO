using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            const int codigo = 0;
            const int descricao = 1;
            const int valor = 2;

            var opcao = "";
            string[,] produtos = new string[100, 3];

            int indiceVetor = 0;

            while (opcao != "0")
            {
                Console.Clear();
                Console.WriteLine("Digite a op��o desejada: \n 1 - Incluir Produto \n 2 - Alterar Produto \n 3 - Consultar Produto \n 4 - Imprimir Todos \n 0 - Sair do Sistema");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Console.Clear();
                        Console.WriteLine("Voc� est� incluindo um produto!");

                        //Recebe a codigo do produto digitada pelo usuario
                        Console.WriteLine("C�digo:");
                        produtos[indiceVetor, codigo] = Console.ReadLine();

                        //Recebe a descri��o do produto digitada pelo usuario
                        Console.WriteLine("Descri��o:");
                        produtos[indiceVetor, descricao] = Console.ReadLine();

                        //Recebe o valor do produto digitada pelo usuario
                        Console.WriteLine("Valor:");
                        produtos[indiceVetor, valor] = Console.ReadLine();

                        //Incrementa o indice do vetor para saber onde ser� incluido o pr�ximo
                        indiceVetor += 1;
                        Console.WriteLine("Produto cadastrado com sucesso! Pressione qualquer tecla para continuar...");
                        Console.ReadLine();
                        break;


                    case "2":

                        Console.Clear();
                        Console.WriteLine("Voc� est� alterando um produto!");
                        Console.WriteLine("Digite o c�digo do produto que deseja alterar:");
                        var codigoAlteracao = Console.ReadLine();
                        for (int i = 0; i < indiceVetor; i++)
                        {
                            if (produtos[i, codigo] == codigoAlteracao)
                            {
                                Console.WriteLine("Digite a nova descri��o:");
                                produtos[i, descricao] = Console.ReadLine();

                                Console.WriteLine("Digite o novo valor:");
                                produtos[i, valor] = Console.ReadLine();

                                Console.WriteLine("Produto alterado com sucesso!Pressione qualquer tecla para continuar...");

                                Console.ReadLine();
                                Console.Clear();

                            }
                            break;
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Voc� est� consultando um produto!");
                        Console.WriteLine("Digite o c�digo do produto que deseja consultar:");
                        var codigoConsulta = Console.ReadLine();

                        for (int i = 0; i < produtos.GetLength(0); i++)
                        {
                            if (produtos[i, codigo] == codigoConsulta)
                            {
                                Console.Clear();
                                Console.WriteLine("Produto encontrado");
                                Console.WriteLine("Codigo: " + produtos[i, codigo]);
                                Console.WriteLine("Descricao: " + produtos[i, descricao]);
                                Console.WriteLine("Valor: " + produtos[i, valor]);
                                Console.WriteLine("Pressione qualquer tecla para continuar...");
                                Console.ReadLine();
                            }
                            break;
                        }

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Imprimindo todos os produtos \n \n");
                        for (int i = 0; i <  indiceVetor; i++)
                        {
                            Console.WriteLine(produtos[i, codigo] + " | " + produtos[i, descricao] + " | " + produtos[i, valor] + " | ");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadLine();
                        break;

                    case "0":
                        break;
                    default:
                        Console.WriteLine("Op��o inv�lida! Pressione qualquer tecla para continuar...");
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Voc� saiu do sistema");
            Console.ReadLine();

        }
    }
}
