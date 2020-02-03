
using System;
using System.Collections.Generic;
namespace ComparisonDelegate
{
    public class Employee : IComparable<Employee>
    {
        public int empid { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        /// <summary>
        /// CompareTo function written based on empid to sort Employee List
        /// </summary>
        /// <param name="other">Takes other Employee object as parameter</param>
        /// <returns></returns>
        public int CompareTo(Employee other)
        {
            if (this.empid < other.empid)
            {
                return -1;
            }
            else if (this.empid > other.empid)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp1 = new Employee { empid = 102, name = "Bhavishya", salary = 49000.98 };
            Employee emp2 = new Employee { empid = 113, name = "Ram", salary = 46000.16 };
            Employee emp3 = new Employee { empid = 030, name = "Sita", salary = 51000.89 };
            List<Employee> myEmp = new List<Employee>() { emp1, emp2, emp3 };
            myEmp.Sort();
            Console.WriteLine("----sorted by empid----\n");
            foreach (Employee emp in myEmp)
            {
                Console.WriteLine(emp.empid + " " + emp.name + " " + emp.salary);
            }
            Comparison<Employee> mydel = new Comparison<Employee>(CompareEmployee);
            myEmp.Sort(mydel);
            Console.WriteLine("\n----sorted by salary----\n");
            foreach (Employee emp in myEmp)
            {
                Console.WriteLine(emp.empid + " " + emp.name + " " + emp.salary);
            }
        }

        private static int CompareEmployee(Employee x, Employee y)
        {
            return x.salary.CompareTo(y.salary);
        }
    }
}







