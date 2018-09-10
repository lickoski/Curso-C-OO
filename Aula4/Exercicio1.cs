using System;
					
public class Program
{
	public static void Main()
	{
		string[] pessoas = new String[5];
		
		for(int i = 0;i<5;i++)
		{
			Console.WriteLine("Digite o nome da pessoa!");
			pessoas[i] = Console.ReadLine();
		}
		
		for(int i = 0;i<5;i++)
		{
			Console.WriteLine(pessoas[i]);
		}
		
		Console.ReadLine();
		
	}
}