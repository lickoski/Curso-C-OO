using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite um valor:");
		var valor = int.Parse(Console.ReadLine());
		
		while(valor >= 0)
		{
			Console.WriteLine(valor.ToString());
			valor--;
		}
		
		Console.ReadLine();
	}
}