using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente
            {
                Nome = "Tiago",
                Endereco = "Romeu Morsh",
                 Cpf = "00000",
                 Idade = 15,
                 Salario = 999
            };


            var cliente2 = new Cliente
            {
                Nome = "Jozias",
                Endereco = "Romeu Morsh",
                Cpf = "00000",
                Idade = 15,
                Salario = 999
            };

            Console.WriteLine(cliente.Nome);

            Console.WriteLine(cliente2.Nome);

            Console.ReadLine();


            var clientes = new Cliente[100];

            clientes[0] = cliente;
            clientes[1] = cliente2;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(clientes[i].Nome);
            }

            Console.ReadLine();



        }
    }
}
