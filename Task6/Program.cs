using System;

namespace Task6
{
    public class Program
    {
       
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {        
            if (b == 0)
                throw new DivideByZeroException("Dividing by zero");
            return a / b;

        }
        static void Main(string[] args)
        {
            
        }
    }
}
