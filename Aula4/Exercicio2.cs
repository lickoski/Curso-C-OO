using System;
					
public class Program
{
	public static void Main()
	{	
		Console.WriteLine("De quantas pessoas vc quer ler o salario?");
		int qtdPessoas = int.Parse(Console.ReadLine());
		decimal[] pessoas = new decimal[qtdPessoas];
		
		for(int i = 0;i<pessoas.Length;i++)
		{
			Console.WriteLine("Digite o sal�rio da pessoa n�mero " + (i+1));
			pessoas[i] = decimal.Parse(Console.ReadLine());
		}
		
		var soma=0M;
		for(int i = 0;i<pessoas.Length;i++)
		{
			soma+=pessoas[i];
		}
		
		Console.WriteLine("A soma total de salarios �:" + soma);
		Console.ReadLine();
		
	}
}