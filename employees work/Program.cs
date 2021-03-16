using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damilare
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary;


        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }



    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Damilare", "Idowu", 300000m);
            Employee employee2 = new Employee("Dayo", "Idowu", 200000m);
            Employee employee3 = new Employee("Tola", "Idowu", 150000m);

            Console.WriteLine("Employee1 Name is: {0} {1}", employee1.FirstName, employee1.LastName);
            Console.WriteLine("Employee1 Salary is: £{0}", employee1.Salary);
            employee1.Salary = employee1.Salary * 12;
            Console.WriteLine("Employee1 yearly salary is: £{0}", employee1.Salary);

            Console.WriteLine("Employee2 Name is: {0} {1}", employee2.FirstName, employee2.LastName);
            Console.WriteLine("Employee2 Salary is: £{0}", employee2.Salary);
            employee2.Salary = employee2.Salary * 12;
            Console.WriteLine("Employee2 yearly salary is: £{0}", employee2.Salary);

            Console.WriteLine("Employee3 Name is: {0} {1}", employee3.FirstName, employee3.LastName);
            Console.WriteLine("Employee3 Salary is: £{0}", employee3.Salary);
            employee3.Salary = employee3.Salary * 12;
            Console.WriteLine("Employee3 yearly salary is: £{0}", employee3.Salary);

            Console.WriteLine();
            Console.WriteLine("After 10% increase");

            employee1.Salary = employee1.Salary * 1.1m;
            employee2.Salary = employee2.Salary * 1.1m;
            employee3.Salary = employee3.Salary * 1.1m;

            Console.WriteLine("Employee1 new Salary is: £{0}", employee1.Salary);
            Console.WriteLine("Employee2 new Salary is: £{0}", employee2.Salary);
            Console.WriteLine("Employee3 new Salary is: £{0}", employee3.Salary);


            Console.ReadLine();
        }
    }
}
