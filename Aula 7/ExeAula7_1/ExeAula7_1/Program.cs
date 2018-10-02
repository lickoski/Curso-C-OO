using Exercicio1Aula7.Carros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeAula7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de carros: ");
            var x = int.Parse(Console.ReadLine());
            var carros = new Carro[x];
            Console.Clear();

            for (int i = 0; i < x; i++)
            {
                var carro = new Carro();
                Console.Write("Informe o marca do carro: ");
                carro.Marca = Console.ReadLine();
                Console.Write("Informe o modelo do carro: ");
                carro.Modelo = Console.ReadLine();
                Console.Write("Informe o cor do carro: ");
                carro.Cor = Console.ReadLine();

                var motor = new Motor();
                Console.Write("Informe a quantidade de cavalos do motor: ");
                motor.QtdCavalos = int.Parse(Console.ReadLine());
                Console.Write("Informe o tipo de combustível do motor: ");
                motor.TipoCombustivel = Console.ReadLine();

                carro.Motor = motor;
                carros[i] = carro;
                Console.Clear();
            }

            for (int i = 0; i < x; i++)
            {
                if (carros[i].Motor.QtdCavalos > 100)
                {
                    Console.WriteLine(carros[i].Marca + " " + carros[i].Modelo + " da cor " + carros[i].Cor + " e tipo de combustível " + carros[i].Motor.TipoCombustivel + " possui " + carros[i].Motor.QtdCavalos + " cavalos.");
                }
            }
            Console.ReadKey();
        }
    }
}
