using System;
					
public class Program
{
	public static void Main()
	{	
		const int nome = 0;
		const int cidade = 1;
		const int bairro = 2;
		const int estado = 3;
		
		Console.WriteLine("De quantos clientes você quer ler os dados?");
		int qtdPessoas = int.Parse(Console.ReadLine());
		string[,] pessoas = new string[qtdPessoas,4];
		
		for(int i = 0;i<pessoas.GetLength(0);i++)
		{
			Console.WriteLine("Digite o nome da pessoa numero " + (i+1));
			pessoas[i, nome] = Console.ReadLine();
			
			Console.WriteLine("Digite o cidade da pessoa numero " + (i+1));
			pessoas[i, cidade] = Console.ReadLine();
			
			Console.WriteLine("Digite o bairro da pessoa numero " + (i+1));
			pessoas[i, bairro] = Console.ReadLine();
			
			Console.WriteLine("Digite o estado da pessoa numero " + (i+1));
			pessoas[i, estado] = Console.ReadLine();
		}
		
		for(int i = 0;i<pessoas.GetLength(0);i++)
		{
			Console.WriteLine(pessoas[i, nome] + " | " + pessoas[i, cidade] + " | " + pessoas[i, bairro] + " | " + pessoas[i, estado]);
		}
		
		
		Console.ReadLine();
	}
}