using System;
using System.Text;

namespace ConsoleApplication
{
    public class Employees
    {
        private Employee[] employees;
        
        public Employees () 
        {
            employees = new Employee[]{
                new HourlyEmployee(1),
                new HourlyEmployee(2),
                new SalariedEmployee(3),
                new HourlyEmployee(4)
            };
        }

        public string generate()
        {
            var result = new StringBuilder();
            foreach (var employee in employees)
            {
                if (employee is HourlyEmployee)
                {
                    result.Append(((HourlyEmployee)employee).reportQtdHours());    
                    result.Append("\n");    
                }
            }
            return result.ToString();
        } 
    }

    public abstract class Employee
    {
        protected int id; 
        public Employee(int id)
        {
            this.id = id;
        }
    }

    public class HourlyEmployee : Employee
    {
        public HourlyEmployee(int id ) : base (id) { }

        public string reportQtdHours()
        {
            return string.Format("Worked hour for {0}", id );
        }
    }

    public class SalariedEmployee : Employee
    {
        public SalariedEmployee(int id ) : base (id) { }
    }
}