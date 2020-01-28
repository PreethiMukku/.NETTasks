using System;
using System.ComponentModel;
using System.IO;

namespace DisposeExample
{
    class Dispo : IDisposable
    {
        bool disposed = false;
        private Component component = new Component(); // managed resource
        private FileStream file = File.Open(@"C:\Users\Preethi_Mukku\Desktop\hello.txt", FileMode.Open); //unmanaged resource
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                Console.WriteLine("cleared managed resources");
                component.Dispose();
            }
            Console.WriteLine("cleared unmanaged resources");
            file.Close();
            disposed = true;
            
        }

        ~Dispo()
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
