using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite a operação que deseja realizar(+, -, *, /):");
		var operacao = Console.ReadLine();
		
		switch(operacao){
			case "+":
				Console.WriteLine("Adição");
				break;
			case "-":
				Console.WriteLine("Subtração");
				break;
			case "*":
				Console.WriteLine("Multiplicação");
				break;
			case "/":
				Console.WriteLine("Divisão");
				break;
			default:
				Console.WriteLine("Operação inválida!");
				break;
		}
		
		Console.ReadLine();
	}
}