using System;

namespace Task5
{
    class Example
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            
            Console.WriteLine("Reverse of a number = "+ obj.ReverseOfNum(2534));
        }
    }
    /// <summary>
    /// The class contains a method to reverse a number 
    /// </summary>
    class Program
    {
        int num = 0;
        /// <summary>
        /// This method performs reverse operation and returns the result
        /// </summary>
        /// <param name="n">
        /// This takes an integer value
        /// </param>
        /// <returns>
        /// Returns a number which is the reverse of the giving number
        /// </returns>
        public int ReverseOfNum(int n)
        {
            while (n > 0)
            {   
                num = num * 10 + n % 10;
                n = n / 10;
            }
            return num;
        }
    }
}

