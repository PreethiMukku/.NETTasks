using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace EquatableInterface
{
    /// <summary>
    /// Class implementing IEquatable interface
    /// </summary>
    public class Student : IEquatable<Student>
    {
        public string name;
        public int id;
        public Student(string firstName, int id)
        {
            this.name = firstName;
            this.id = id;
        }

        /// <summary>
        /// Equal Method implementation
        /// </summary>
        /// <param name="other">Takes Student type object</param>
        /// <returns>Returns a boolean value</returns>
        public bool Equals(Student other)
        {
            if(other != null)
            {
                return this.name.Equals(other.name) && this.id.Equals(other.id);
            }
            throw new NotImplementedException();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Preethi", 0101);
            Student s2 = new Student("Bhavishya", 0967);
            Student s3 = new Student("Rishitha", 0162);
            Student s4 = new Student("Usha", 0271);
            ArrayList list = new ArrayList() { s1, s2, s3, s4 };

            Student candidate = new Student("Bhavishya", 0967);


            if (s2.Equals(candidate))
            {
                Console.WriteLine("Candidate is available");
            }
            else
            {
                Console.WriteLine("Candidate is not available");
            }
        }
    }
}
