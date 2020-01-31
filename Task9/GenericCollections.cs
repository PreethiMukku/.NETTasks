using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollections
{
    /// <summary>
    /// Generic Collections
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> slist = new SortedList<int, string>();
            
            slist.Add(1,"Dot Net");
            slist.Add(2, "Java");
            slist.Add(3, "DEP");
            slist.Add(4, "SDET");
            slist.Add(5, "Devops");
            Console.WriteLine("\n---Sorted List");
            foreach (KeyValuePair<int, string> x in slist)
            {
                Console.WriteLine(x.Key+" "+x.Value);
            }
    
            Console.WriteLine("DEP in list = "+slist.ContainsValue("DEP"));
        
            slist.RemoveAt(3);
            Console.WriteLine("---After removing---");

            foreach (KeyValuePair<int, string> x in slist)
            {
                Console.WriteLine(x.Key + " " + x.Value);
            }
            
            // DSICTIONARY  
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(120, "DEP");
            dict.Add(213, "DOT NET");
            dict.Add(113, "SalesForce");
            dict.Add(315, "JAVA");

            Console.WriteLine("\n---Dictionary---");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //LIST
            List<int> listObj = new List<int>();
            listObj.Add(123);
            listObj.Add(235);
            listObj.Add(301);
            listObj.Add(325);

            Console.WriteLine("\n---List---");
            foreach (var el in listObj)
                Console.WriteLine(el);

            // STACK  
            Stack<int> objStack = new Stack<int>();
            objStack.Push(110);
            objStack.Push(212);
            objStack.Push(344);

            Console.WriteLine("\n---Stack---");
            foreach (var el in objStack)
                Console.WriteLine(el);

            // QUEUES 
            Queue<int> objQueue = new Queue<int>();
            objQueue.Enqueue(1);
            objQueue.Enqueue(2);
            objQueue.Enqueue(3);

            Console.WriteLine("\n---Queue---");
            foreach (var el in objQueue)
                Console.WriteLine(el);
        }
    }
}
