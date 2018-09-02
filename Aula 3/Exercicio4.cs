using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite um valor:");
		var valor = int.Parse(Console.ReadLine());
		var resposta = "s";
		
		while(resposta == "s")
		{
			Console.WriteLine(valor.ToString());
			valor--;
			
			Console.WriteLine("Deseja continuar escrevendo na tela?(Digite s para SIM ou qualquer outro valor para NÃO!)");
			resposta = Console.ReadLine();
		}
		Console.WriteLine("Programa chegou a seu final!");
		Console.ReadLine();
	}
}