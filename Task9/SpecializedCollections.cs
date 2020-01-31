using System;
using System.Collections;
using System.Collections.Specialized;

namespace SpecialisedCollections
{
    /// <summary>
    /// String Collection implementation
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StringCollection myCol = new StringCollection();

            // Add a range of elements from an array to the end of the StringCollection.
            String[] arr = new String[] { "Dot Net", "Java", "DEP", "SDET", "Devops" };
            myCol.AddRange(arr);
            PrintValues(myCol);
            myCol.Insert(3, "SalesForce");
            Console.WriteLine("After inserting SalesForce at index 3:");
            PrintValues(myCol);

            // Copy the collection to a new array starting at index 0.
            String[] myArr = new String[myCol.Count+1];
            myArr[0] = "Hello";
            myCol.CopyTo(myArr, 1);

            Console.WriteLine("The new array contains:");
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(i + " " + myArr[i]);
            }
            Console.WriteLine();

            HybridDictionary hybridDictionary = new HybridDictionary();
            hybridDictionary.Add("Braeburn Apples", "1.49");
            hybridDictionary.Add("Fuji Apples", "1.29");
            hybridDictionary.Add("Gala Apples", "1.49");
            hybridDictionary.Add("Golden Delicious Apples", "1.29");
            hybridDictionary.Add("Granny Smith Apples", "0.89");
            hybridDictionary.Add("Red Delicious Apples", "0.99");
            hybridDictionary.Add("Plantain Bananas", "1.49");
            hybridDictionary.Add("Yellow Bananas", "0.79");
            hybridDictionary.Add("Strawberries", "3.33");
            hybridDictionary.Add("Cranberries", "5.98");
            hybridDictionary.Add("Navel Oranges", "1.29");
            hybridDictionary.Add("Grapes", "1.99");
           
            // Display the contents of the collection using foreach. This is the preferred method.
            Console.WriteLine("Displays the elements using foreach:\n");
            Print(hybridDictionary);

            // Copies the HybridDictionary to an array with DictionaryEntry elements.
            DictionaryEntry[] my_arr = new DictionaryEntry[hybridDictionary.Count];
            hybridDictionary.CopyTo(my_arr, 0);

            // Displays the values in the array.
            Console.WriteLine("\nContents of array : \n");
            for (int i = 0; i < my_arr.Length; i++)
                Console.WriteLine(my_arr[i].Key+"  "+my_arr[i].Value);
            Console.WriteLine();

            // Searches for a key.
            if (myCol.Contains("Kiwis"))
                Console.WriteLine("The collection contains the key Kiwis.");
            else
                Console.WriteLine("The collection does not contain the key \"Kiwis\".");
            Console.WriteLine();


            //NAMEVALUECOLLECTION
            NameValueCollection nameValCol = new NameValueCollection();
            nameValCol.Add("red", "KingsXlPunjab");
            nameValCol.Add("Orange", "Sunrisers");
            nameValCol.Add("blue", "Mumbai Indians");
            nameValCol.Add("Yellow", "Chennai Superkings");

            // Displays the values in the NameValueCollection.
            Console.WriteLine("\nNameValueCollection Data:\n");
            PrintKeysAndValues(nameValCol);

            // Gets a value either by index or by key.
            Console.WriteLine("Index 1 contains the value {0}.", nameValCol[1]);
            Console.WriteLine("Key \"red\" has the value {0}.", nameValCol["red"]);
        }
        public static void Print(IDictionary col)
        {
            foreach (DictionaryEntry de in col)
                Console.WriteLine(de.Key + " " + de.Value);
            Console.WriteLine();
        }

        public static void PrintValues(StringCollection col)
        {
            foreach (Object obj in col)
                Console.WriteLine(obj);
            Console.WriteLine();
        }

        public static void PrintKeysAndValues(NameValueCollection myCol)
        {
            foreach (String s in myCol.AllKeys)
                Console.WriteLine(s+" "+myCol[s]);
            Console.WriteLine();
        }
    }
}

