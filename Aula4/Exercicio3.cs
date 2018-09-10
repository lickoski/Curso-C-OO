using System;
					
public class Program
{
	public static void Main()
	{	
		Console.WriteLine("De quantas pessoas vc quer ler a idade?");
		int qtdPessoas = int.Parse(Console.ReadLine());
		int[] pessoas = new int[qtdPessoas];
		
		for(int i = 0;i<pessoas.Length;i++)
		{
			Console.WriteLine("Digite a idade da pessoa número " + (i+1));
			pessoas[i] = int.Parse(Console.ReadLine());
		}
		
		for(int i = 0;i<pessoas.Length;i++)
		{
			if(pessoas[i] > 18)
				Console.WriteLine(pessoas[i]);
		}
		
		Console.ReadLine();
	}
}