using System;
using System.Collections;


namespace EquatableInterface
{
    /// <summary>
    /// Student class
    /// </summary>
    public class Student
    {
        public string name;
        public int id;
        public Student(string firstName, int id)
        {
            this.name = firstName;
            this.id = id;
        }
    }
    /// <summary>
    /// School class implementing enumerable interface
    /// </summary>
    class School : IEnumerable
    {
        private Student[] s_arr = new Student[5];
        public School()
        {
            s_arr[0] = new Student("Preethi", 0101);
            s_arr[1] = new Student("Bhavishya", 0967);
            s_arr[2] = new Student("Rishitha", 0162);
            s_arr[3] = new Student("Usha", 0271);
            s_arr[4] = new Student("Jaya", 0311);
        }

        public IEnumerator GetEnumerator()
        {
            return new SchoolEnumerator(s_arr);
        }
    }

    /// <summary>
    /// Classs implementing IEnumerator interface
    /// </summary>
    class SchoolEnumerator : IEnumerator
    {
        public Student[] s_arr;
        public SchoolEnumerator(Student[] list)
        {
            s_arr = list;
        }
        private int position = -1;
        public IEnumerator GetEnumerator()
        {
            return s_arr.GetEnumerator();
        }

        public bool MoveNext()
        {
            position++;
            return position < s_arr.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Student Current
        {
            get
            {
                try
                {
                    return s_arr[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            School school = new School();
            foreach (Student s in school)
            {
                Console.WriteLine(s.id+" "+s.name);
            }

        }
    }
}


