using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Quantas pessoas participaram da pesquisa?");
		var quantidadeDePessoas = int.Parse(Console.ReadLine());
		var somaIdade = 0;
		
		for(int i=0; i<quantidadeDePessoas;i++)
		{
			
			Console.WriteLine("Digite a idade:");
			somaIdade += int.Parse(Console.ReadLine());
		}
		Console.WriteLine("A média de idade é:" + somaIdade / quantidadeDePessoas);
		Console.ReadLine();
	}
}