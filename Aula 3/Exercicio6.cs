using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o valor a ser multiplicado por 2:");
		var valor = int.Parse(Console.ReadLine());
		
		for(int i = valor; i>0;i--)
		{
			Console.WriteLine(i + " * 2 =" + i * 2);
		}
		Console.ReadLine();
	}
}