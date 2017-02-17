using System;
using UtilityMethods;

public class Test
{
	public static void Main()
	{
		int num1, num2;
		int sum, mult;

		Console.Write("Enter Number 1 : ");
		num1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter Number 2 : ");
		num2 = Convert.ToInt32(Console.ReadLine());

		sum = AddClass.Add(num1, num2);
		mult = MultClass.Mult(num1, num2);

		Console.WriteLine("Addition of {0} and {1} is : {2}", num1, num2, sum);
		Console.WriteLine("Multiplication of {0} and {1} is : {2}", num1, num2, mult);
	}
}