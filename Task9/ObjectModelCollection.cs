using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ObjectModelCollections
{
    /// <summary>
    /// ObjectModel Collections
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Dot Net");
            list.Add("Java");
            list.Add("DEP");
            list.Add("SDET");
            list.Add("Devops");
            //READONLY COLLECTION //READONLY COLLECTION
            ReadOnlyCollection<string> readOnlyList =
                new ReadOnlyCollection<string>(list);
            foreach (string item in readOnlyList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCount: " + readOnlyList.Count);
            Console.WriteLine("\nInsert into the wrapped List:");
            list.Insert(2, "Salesforce");
            Console.WriteLine();
            foreach (string dinosaur in readOnlyList)
            {
                Console.WriteLine(dinosaur);
            }

            string[] listArray = new string[readOnlyList.Count + 2];
            readOnlyList.CopyTo(listArray, 1);

            Console.WriteLine("\nCopied array has {0} elements:",
                listArray.Length);
            foreach (string s in listArray)
            {
                Console.WriteLine("\"{0}\"", s);
            }

        }
    }
}

