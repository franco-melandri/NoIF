using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // var employees = new Employees();
            var employees = new EmployeesNoIf();

            Console.WriteLine("Report");
            Console.WriteLine (employees.generate());
            Console.ReadKey();
        }
    }
}
