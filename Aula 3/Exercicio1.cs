using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite a opera��o que deseja realizar(+, -, *, /):");
		var operacao = Console.ReadLine();
		
		switch(operacao){
			case "+":
				Console.WriteLine("Adi��o");
				break;
			case "-":
				Console.WriteLine("Subtra��o");
				break;
			case "*":
				Console.WriteLine("Multiplica��o");
				break;
			case "/":
				Console.WriteLine("Divis�o");
				break;
			default:
				Console.WriteLine("Opera��o inv�lida!");
				break;
		}
		
		Console.ReadLine();
	}
}