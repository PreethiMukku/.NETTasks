using System;

namespace GarbageCollection
{
    /// <summary>
    /// Class for garbage collector
    /// </summary>
    class Collector
    {
        /// <summary>
        /// constructor of the class
        /// </summary>
        public Collector()
        {
            Console.WriteLine("Creating Object");
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~Collector()
        {
            Console.WriteLine("Object is Destroyed");
        }
    }

    class Sample
    {
        static void Main(string[] args)
        {
            Collector obj = new Collector();
            Console.WriteLine("object is created");
            obj = null;
            // gc.collect() method to destroy unused objects.
            GC.Collect();
            Console.WriteLine("Object is assigned to null");
            Console.ReadLine();
        }
    }
}
