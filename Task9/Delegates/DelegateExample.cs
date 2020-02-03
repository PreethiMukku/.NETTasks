using System;

namespace Delegates
{
    class Program
    {
        public int AddNum(int num1, int num2)
        {
            return num1+num2;
        }
        public int MultNum(int num1, int num2)
        {
            return num1 * num2;
        }

        public delegate int AdditionDelegate(int a, int b);
        public delegate int MultiplicationDelegate(int a, int b);
        static void Main(string[] args)
        {
            Program obj = new Program();
            AdditionDelegate add_del = new AdditionDelegate(obj.AddNum);
            MultiplicationDelegate mul_del = new MultiplicationDelegate(obj.MultNum);

            Console.WriteLine(add_del(4,8));
            Console.WriteLine(mul_del(4,6));
        }
    }
}

