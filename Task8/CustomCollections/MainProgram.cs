using System;
using MyList;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
			ListOperations list = new ListOperations();

			list.Add("Hello");
			list.Add("Magical");
			list.Add(10);
			list.Add("World");
			list.Add(34);
			list.Reverse();
			list.ForEach();
		
		}
    }
}
