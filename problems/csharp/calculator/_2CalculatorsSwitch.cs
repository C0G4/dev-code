using System;
using System.Globalization;

class MainClass {
  public static void Main (string[] args) {

    Console.Write("\n\tCalculadora Switch\n" +
			"\n\tChoose a mathematical operation: " +
			"\n\t\t1 - Addition;" +
			"\n\t\t2 - Subtraction;" +
			"\n\t\t3 - Multiplication;" +
			"\n\t\t4 - Division;" +
			"\n\tOption: ");
		byte operation = byte.Parse(Console.ReadLine());
		
		Console.Write("\n\tValue 1: ");
		double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		Console.Write("\n\tValue 2: ");
		double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

		switch (operation) 
		{
			case 1:
							{	
								Console.Write("\n\tAddition result {0}", (v1 + v2).ToString("F2", CultureInfo.InvariantCulture));
								break;
							}
			case 2:
							{
								Console.Write("\n\tSubtraction result {0}", (v1 - v2).ToString("F2", CultureInfo.InvariantCulture));
								break;
							}
			case 3:
							{
								Console.Write("\n\tMultiplication Result {0}", (v1 * v2).ToString("F2", CultureInfo.InvariantCulture));
								break;
							}
			case 4:
							{
								Console.Write("\n\tDivision Result {0}", (v1 / v2).ToString("F2", CultureInfo.InvariantCulture));
								break;
							}
			default:
							{
								Console.Write("\n\tInvalid value!!!!");
								break;
							}
		}
		

  }
}
