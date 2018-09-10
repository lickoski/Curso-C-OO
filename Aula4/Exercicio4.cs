using System;
					
public class Program
{
	public static void Main()
	{	
		Console.WriteLine("De quantas pessoas vc quer ler o nome?");
		int qtdPessoas = int.Parse(Console.ReadLine());
		string[] pessoas = new string[qtdPessoas];
		
		for(int i = 0;i<pessoas.Length;i++)
		{
			Console.WriteLine("Digite o nome da pessoa numero " + (i+1));
			pessoas[i] = Console.ReadLine();
		}
		
		string[] pessoasComCinco = new string[5];
		
		for(int i = 0;i<5;i++)
		{
			pessoasComCinco[i] = pessoas[i];
		}
		
		for(int i = 0;i<pessoasComCinco.Length;i++)
		{
			Console.WriteLine("Pessoa numero " + (i+1) + ": " + pessoasComCinco[i]);
		}
		
		
		Console.ReadLine();
	}
}