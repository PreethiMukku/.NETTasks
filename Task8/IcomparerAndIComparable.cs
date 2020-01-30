using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ComparerInterface
{
    /// <summary>
    /// Class Implementing Icomparable inetrface
    /// </summary>
    public class Student : IComparable<Student>
    {
        public string name;
        public int marks;
        public Student(string firstName, int marks)
        {
            this.name = firstName;
            this.marks = marks;
        }

        /// <summary>
        /// CompareTo method implementation
        /// </summary>
        /// <param name="other">Takes object of type Student</param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            if(other != null)
            {
                return this.name.CompareTo(other.name);
            }
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Class Implementing Icomparer interface
    /// </summary>
    public class Comparer:IComparer<Student>
    { 
        /// <summary>
        /// Compare method implementation Sorts in Ascending order
        /// </summary>
        /// <param name="x">Takes value of type Student</param>
        /// <param name="y">Takes value of type Student</param>
        /// <returns></returns>
        public int Compare(Student x, Student y)
        {
            if (x.marks > y.marks)
                return 1;
            if (x.marks < y.marks)
                return -1;
            return 0;
        }
    }

    /// <summary>
    /// Class implementing Icomparer Interface
    /// </summary>
    public class DescendingComparer : IComparer<Student>
    {
        /// <summary>
        /// Compare method, Sorts in descending order
        /// </summary>
        /// <param name="x">Value is of Student type</param>
        /// <param name="y">Value of Student type</param>
        /// <returns></returns>
        public int Compare(Student x, Student y)
        {
            if (x.marks < y.marks)
                return 1;
            if (x.marks > y.marks)
                return -1;
            return 0;
        }
    }

    /// <summary>
    /// Main Program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Preethi", 98);
            Student s2 = new Student("Bhavishya", 74);
            Student s3 = new Student("Rishitha", 45);
            Student s4 = new Student("Usha", 66);
            Student s5 = new Student("Harika", 47);
            Student s6 = new Student("Akhila", 32);
            Student s7 = new Student("Chetana", 59);
            Student s8 = new Student("Jasmine", 77);

            Student[] s_arr = new Student[] { s1, s2, s3, s4, s5, s6, s7, s8 };

            //Printing data present in array
            Console.WriteLine("STudents data----");
            foreach (Student s in s_arr)
            {
                Console.WriteLine(s.name + "  " + s.marks);
            }
            Console.WriteLine();

            //printing sorted names using Icomparable
            Console.WriteLine("Sorting based on names ------> IComparable");
            Array.Sort(s_arr);
            foreach (Student s in s_arr)
            {
                Console.WriteLine(s.name+"  "+s.marks);
            }
            Console.WriteLine();

            //printing data sorted based on marks in Ascending order uses Icomparer
            Console.WriteLine("Sorting based on marks ------> IComparer");
            Array.Sort(s_arr,new Comparer());            
            foreach (Student s in s_arr)
            {
                Console.WriteLine(s.name + "  " + s.marks);
            }
            Console.WriteLine();

            //printing data sorted based on marks in Descending order uses Icomparer
            Console.WriteLine("Sorting marks in descending order ------> IComparer");
            Array.Sort(s_arr, new DescendingComparer());
            foreach (Student s in s_arr)
            {
                Console.WriteLine(s.name + "  " + s.marks);
            }
            Console.WriteLine();

            //printing a range of data sorted based in Ascending order uses Icomparable
            Console.WriteLine("Sorting a range of values ------> IComparable");
            Array.Sort(s_arr,1,5);
            foreach (Student s in s_arr)
            {
                Console.WriteLine(s.name + "  " + s.marks);
            }
            Console.WriteLine();

            //printing a range of data sorted based on marks in descending order uses Icomparer
            Console.WriteLine("Sorting a range of values in descending order ------> IComparer");
            Array.Sort(s_arr, 1, 5, new DescendingComparer());
            foreach (Student s in s_arr)
            {
                Console.WriteLine(s.name + "  " + s.marks);
            }
            Console.WriteLine();
        }
    }
}
