using System;
using System.Collections;
namespace TestApp
{
    /// <summary>
    /// Collections implementation
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[6];
            arr[0] = "Hello";
            arr[1] = 4;
            arr[2] = "World";
            arr[3] = 3.5;
            arr[4] = 1.3;
            arr[5] = "DOT NET";

            //ARRAY LIST
            ArrayList al = new ArrayList();
            
            for(int i = 0; i < arr.Length; i++)
            {
                al.Add(arr[i]);
            }
            //printing the data
            Console.WriteLine("----ArrayList Before removing----");
            Display(al);
            Console.WriteLine("\nNo of elements in list = "+al.Count);
            al.RemoveAt(2);
            Console.WriteLine("----After removing----");
            Display(al);

            //STACK
            Stack myStack = new Stack();

            for (int i = 0; i < arr.Length; i++)
            {
                myStack.Push(arr[i]);
            }
            Console.WriteLine("\n----Stack Before removing----");
            Display(myStack);//print 
            Console.WriteLine("\nobject at the end of stack = " + myStack.Pop());
            Console.WriteLine("\n----After removing----");
            Display(myStack);//print
            Console.WriteLine("Synchronized = " + myStack.IsSynchronized);

            //QUEUE
            Queue queue = new Queue();

            for (int i = 0; i < arr.Length; i++)
            {
                queue.Enqueue(arr[i]);
            }

            Console.WriteLine("\n----Queue Before removing----");
            Display(queue);
            Console.WriteLine("\nobject at the beginning of queue = " + queue.Dequeue());
            Console.WriteLine("\n----After removing----");
            Display(queue);

            //HASHTABLE
            Hashtable ht = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {
                
                ht.Add(i+100,arr[i]);
            }
            // Get a collection of the keys.
            ICollection key = ht.Keys;
            Console.WriteLine("\n----Hashtable---");
            foreach (int k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            if (ht.ContainsValue("IT"))
            {
                Console.WriteLine("The stream is already present in list");
            }
            else
            {
                ht.Add(106, "IT");
                Console.WriteLine("The item IT is added to list");
            }
            Console.WriteLine("IsReadonly = "+ht.IsReadOnly);

            //SORTED LIST
            SortedList sl = new SortedList();
            sl.Add(120, "DEP");
            sl.Add(213, "DOT NET");
            sl.Add(113, "SalesForce");
            sl.Add(315, "JAVA");
            sl.Add(212, "DEVOPS");
            sl.Add(100, "SDET");
            Console.WriteLine("\n---Sorted List---");
            for (int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine(sl.GetKey(i) + " " + sl.GetByIndex(i));
            }
            sl.RemoveAt(2);
            Console.WriteLine("\nThe key 104 is in list is "+sl.ContainsKey(104));
           
        }
        private static void Display(ICollection cs)
        {
            Console.WriteLine();
            foreach (Object item in cs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
