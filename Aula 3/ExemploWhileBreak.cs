using System;
					
public class Program
{
	public static void Main()
	{
		int i = 1;
		while (i <= 10)
		{
			if(i == 5)
				break;
			Console.WriteLine(i);
			i++;
		}
	}
}