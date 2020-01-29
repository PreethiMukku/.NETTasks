using System;
using System.ComponentModel;
using System.IO;

namespace DisposeExample
{
    /// <summary>
    /// Class implementing Idisposable interface
    /// </summary>
    class Dispo : IDisposable
    {
        bool disposed = false;
        private Component component = new Component(); // managed resource
        private FileStream file = File.Open(@"C:\Users\Preethi_Mukku\Desktop\hello.txt", FileMode.Open); //unmanaged resource

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// overloading Dispose method
        /// </summary>
        /// <param name="disposing">Takes boolean value</param>
        private void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                //Code to clean Managed resources 
                Console.WriteLine("cleared managed resources");
                component.Dispose();
            }
            //code to clean Unmanaged resources are cleaned here
            Console.WriteLine("cleared unmanaged resources");
            file.Close();
            disposed = true;
            
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Dispo() //Finalize Method
        {
            Console.WriteLine("Destructor called.");
            Dispose(false);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dispo obj = new Dispo();
            Console.WriteLine("created object");
            obj.Dispose();
            obj = null;
            Console.WriteLine("Assigned null to object");
            Console.ReadLine();
        }
    }
}
