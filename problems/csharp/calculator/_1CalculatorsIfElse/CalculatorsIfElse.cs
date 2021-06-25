using System;
using System.Globalization;

class MainClass {
  public static void Main (string[] args) {

    Console.Write("\n\tChoose a mathematical operation: " + 
												"\n\t\t1 - Addition;" + 
												"\n\t\t2 - Subtraction;" + 
												"\n\t\t3 - Multiplication;" + 
												"\n\t\t4 - Division;"+ 
												"\n\tOption: ");
		byte menu = byte.Parse(Console.ReadLine());

		Console.Write("\n\tValue 1: ");
		double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

		Console.Write("\n\tValue 2: ");
		double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

		double result = 0.00;

		if (menu == 1)
			result = v1 + v2;
		else if (menu == 2)
			result = v1 - v2;
		else if (menu == 3)
			result = v1 * v2;
		else if (menu == 4)
			result = v1 * v2;
		else
			Console.WriteLine("ERRO!!!");
		
		Console.WriteLine("\n\t\tThe result is " + result.ToString("F2", CultureInfo.InvariantCulture));

  }
}		
