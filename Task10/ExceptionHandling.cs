using System;

namespace CalculatorExceptionHandling
{
	public class MultiplyByZeroException : Exception
	{
		public MultiplyByZeroException() : base()
		{
		}
		public MultiplyByZeroException(String message) : base(message)
		{
			message = "Multiplying with zero";
		}
	}
	class Program
    {
		public static int Addition(int operand1, int operand2)
		{
			return operand1 + operand2;
		}
		public static int Subtraction(int operand1, int operand2)
		{
			return operand1 - operand2;
		}
		public static int Multiplication(int operand1, int operand2)
		{
			int result = 0;
			try
			{
				if (operand1 == 0 || operand2 == 0)
				{
					throw new MultiplyByZeroException("Operand should not be zero");
				}
				result = operand1 * operand2;

			}
			catch (MultiplyByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}
			return result;
		}
		public static int Division(int operand1, int operand2)
		{
			int result = 0;
			try
			{
				result = operand1 / operand2;

			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.WriteLine("Finally Block");
			}
			return result;
		}
		
		static void Main(string[] args)
        {
			Console.WriteLine("Enter x value");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter y value");
			int y = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter 1.Add, 2.Sub, 3.Mul, 4.Div");
			int opt = Convert.ToInt32(Console.ReadLine());
			if (opt == 1)
				Console.WriteLine(Addition(x, y));
			else if (opt == 2)
				Console.WriteLine(Subtraction(x, y));
			else if (opt == 3)
				Console.WriteLine(Multiplication(x, y));
			else if (opt == 4)
				Console.WriteLine(Division(x,y));
			else
				Console.WriteLine("Wrong option");
		}
    }
}
