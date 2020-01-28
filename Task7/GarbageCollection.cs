using System;

namespace GarbageCollection
{
    class Collector
    {
        public Collector()
        {
            Console.WriteLine("Creating Object");
        }
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
            Console.WriteLine("Object is assigned to null");
            GC.Collect();
            Console.ReadLine();
        }
    }
}
