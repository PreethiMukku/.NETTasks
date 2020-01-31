using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Threading;

namespace ConcurrentCollections
{
    /// <summary>
    /// Implementing Concurrent collections
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int>[] obj1 = new BlockingCollection<int>[3]; ;
            BlockingCollection<int> obj2 = new BlockingCollection<int>(8); ;
           
            Console.WriteLine("Blocking_Collections_Example");
            obj1[0] = new BlockingCollection<int>(boundedCapacity: 10);
            obj1[1] = new BlockingCollection<int>(boundedCapacity: 10);
            Task t1 = Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 10; ++i)
                {
                    obj1[0].Add(i);
                    Thread.Sleep(100);
                }
                obj1[0].CompleteAdding();
            });
            Console.WriteLine("The elements added in thread 1:");
            foreach (int num in obj1[0].GetConsumingEnumerable())
            {
                Console.WriteLine(num);
            }
            Task t2 = Task.Factory.StartNew(() =>
            {
                for (int i = 11; i <= 20; ++i)
                {
                    obj1[1].Add(i);
                    Thread.Sleep(150);
                }
                obj1[1].CompleteAdding();
            });
            Console.WriteLine("The elements added in thread 2:");
            foreach (int num in obj1[1].GetConsumingEnumerable())
            {
                Console.WriteLine(num);
            }
            while (!obj1[0].IsCompleted || !obj1[1].IsCompleted)
            {
                BlockingCollection<int>.TryTakeFromAny(obj1, out int res, TimeSpan.FromSeconds(1));
                if (res != default(int))
                {
                    Console.WriteLine(res);
                }
            }
            obj2.Add(1);
            obj2.Add(2);
            obj2.Add(3);
            obj2.Add(4);
            obj2.Add(5);
            obj2.Add(6);
            obj2.CompleteAdding();
            Console.WriteLine("The elements added:");
            foreach (int num in obj2)
            {
                Console.WriteLine(num);
            }
            int item = obj2.Take();
            Console.WriteLine("The number deleted is " + item);
            Console.WriteLine("Remaining elements:");
            foreach (int num in obj2)
            {
                Console.WriteLine(num);
            }
            


            // Construct the dictionary
            ConcurrentDictionary<int, int> cd = new ConcurrentDictionary<int, int>();

            // Initialize the dictionary
            for (int num = 0; num < 10; num++)
                cd[num] = num * num;
            Console.WriteLine("\n---Elements in dictionary---");
            foreach(var val in cd)
            {
                Console.WriteLine(val.Key+" "+val.Value);
            }
            Console.WriteLine("\nThe square of \"5\" is "+cd[5]);
            cd.TryRemove(5,out int x);
            Console.WriteLine("\nElement removed is "+x);
            Console.WriteLine("\n---After removing---");
            foreach (var val in cd)
            {
                Console.WriteLine(val.Key + " " + val.Value);
            }

            //Concurrent Stack
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            Console.WriteLine("Concurrent_Stack_Example");
            int y;
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            foreach (int num in stack)
            {
                Console.WriteLine(num);
            }
            stack.TryPop(out y);
            Console.WriteLine("The poped value is " + y);
            int[] i = { 6, 7, 8 };
            stack.PushRange(i);
            foreach (int num in stack)
            {
                Console.WriteLine(num);
            }
            int count = stack.Count;
            Console.WriteLine("The number of elements in stack :" + count);
        }
    }
  
}
