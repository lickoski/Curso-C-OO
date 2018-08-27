using System;
					
public class Program
{
	public static void Main()
	{
		int i = 1;
		while (i <= 10)
		{
			if(i == 5)
			{
				i++;
				continue;
			}
			Console.WriteLine(i);
			i++;
		}
	}
}