using System;
					
public class Program
{
	public static void Main()
	{	
		const int nome = 0;
		const int cidade = 1;
		
		string [,] arraybi = new string[2,2];
		
		arraybi[0,0] = "Tiago";
		arraybi[0,1] = "São Léo";
		
		arraybi[1,0] = "Delfino";
		arraybi[1,1] = "Garopaba";
		
		Console.WriteLine(arraybi[0,nome]);
		Console.WriteLine(arraybi[0,cidade]);
		
		Console.WriteLine(arraybi[1,nome]);
		Console.WriteLine(arraybi[1,cidade]);
	}
}