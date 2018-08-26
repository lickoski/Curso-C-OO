using System;

namespace ExercicioImpostoRenda
{
    class ExercicioImpostoRenda
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Salário:");
            var salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu percentual de aumento:");
           // var percentualAumento = decimal.Parse(Console.ReadLine());

            //salario += (salario * percentualAumento) / 100;

            if (salario <= 1903.98M)
            {
                Console.WriteLine("Você não possui alíquota de imposto de renda!");
            }
            else if (salario > 1903.98M && salario <= 2826.65M)
            {
                Console.WriteLine("Sua alíquota de imposto de renda é 7,5%");
            }
            else if (salario > 2826.65M && salario <= 3751.05M)
            {
                Console.WriteLine("Sua alíquota de imposto de renda é 15%");
            }
            else if (salario > 3751.05M && salario <= 4664.68M)
            {
                Console.WriteLine("Sua alíquota de imposto de renda é 22,5%");
            }
            else if (salario > 4664.68M)
            {
                Console.WriteLine("Sua alíquota de imposto de renda é 27,5%");
            }

            Console.ReadKey();

        }
    }
}
