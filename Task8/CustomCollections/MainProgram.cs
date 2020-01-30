using System;
using MyList;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
			ListOperations list = new ListOperations();

			list.Add(4);
			list.Add(2);
			list.Add(10);
			list.Add(7);
			list.Add(34);
			list.Reverse();
			list.ForEach();
			list.Sort();
			list.ForEach();
		}
    }
}
