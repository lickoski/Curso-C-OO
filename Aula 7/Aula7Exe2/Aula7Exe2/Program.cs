using Exercicio2Aula7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7Exe2
{
    class Program
    {
        static void Main(string[] args)
        {   

            Console.Write("Informe a quantidade de cidades: ");
            var qtdCidades = int.Parse(Console.ReadLine());
            var cidades = new Cidade[qtdCidades];

            bool jaCadastrado = false;

            for (int i = 0; i < qtdCidades; i++)
            {
                jaCadastrado = false;
                Console.Clear();
                while (jaCadastrado != true)
                {
                    var cidade = new Cidade();
                    Console.Write("Informe o nome da " + (i + 1) + "ª cidade: ");
                    cidade.Nome = Console.ReadLine();

                    var estado = new Estado();
                    Console.Clear();
                    Console.Write("Informe em que estado fica " + cidade.Nome + ": ");
                    estado.Nome = Console.ReadLine();

                    var país = new País();
                    Console.Clear();
                    Console.Write("Informe em que país fica " + cidade.Nome + "/" + estado.Nome + ": ");
                    país.Nome = Console.ReadLine();

                    for (int j = 0; j < i; j++)
                    {
                        if (cidade.Nome.ToUpper() == cidades[j].Nome.ToUpper() && estado.Nome.ToUpper() == cidades[j].estado.Nome.ToUpper() && país.Nome.ToUpper() == cidades[j].estado.país.Nome.ToUpper())
                        {
                            Console.WriteLine("Cidade já cadastrada! Aperte qualquer tecla para continuar!");
                            Console.ReadKey();
                            jaCadastrado = false;
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            estado.país = país;
                            cidade.estado = estado;
                            cidades[i] = cidade;
                            jaCadastrado = true;
                        }
                    }
                    if (i == 0)
                    {
                        estado.país = país;
                        cidade.estado = estado;
                        cidades[i] = cidade;
                        jaCadastrado = true;

                    }
                }

            }
            Console.WriteLine("LISTAGEM DE CIDADES");
            for (int i = 0; i < qtdCidades; i++)
            {
                Console.WriteLine("Cidade: " + cidades[i].Nome + " | " + "Estado: " + cidades[i].estado.Nome + " | " + "País: " + cidades[i].estado.país.Nome);
            }
            Console.WriteLine("Aperte qualquer tecla para sair do sistema");
            Console.ReadKey();
        }
    }
}
