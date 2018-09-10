using System;
					
public class Program
{
	public static void Main()
	{	
		const int nome = 0;
		const int idade = 1;
		
		string[,] pessoas = new string[10,2];
		int menorIdade = 0;
		
		for(int i = 0;i<pessoas.GetLength(0);i++)
		{
			Console.WriteLine("Digite o nome da pessoa numero " + (i+1));
			pessoas[i, nome] = Console.ReadLine();
			
			Console.WriteLine("Digite a idade da pessoa numero " + (i+1));
			pessoas[i, idade] = Console.ReadLine();
			
			if(Convert.ToInt32(pessoas[i, idade]) < menorIdade || i == 0)
			{
				menorIdade = Convert.ToInt32(pessoas[i, idade]);
			}
		}
		
		for(int i = 0;i<pessoas.GetLength(0);i++)
		{
			if(Convert.ToInt32(pessoas[i, idade]) < 18)
			{
				Console.WriteLine(pessoas[i, nome] + " é menor de 18 anos!");
			}
		}
		
		Console.WriteLine("A menor idade encontrada é :" + menorIdade);
		
		Console.ReadLine();
	}
}