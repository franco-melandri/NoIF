using System;
using System.Text;

namespace ConsoleApplication
{
    public class EmployeesNoIf
    {
        private EmployeeNoIf[] employees;
        
        public EmployeesNoIf () 
        {
            employees = new EmployeeNoIf[]{
                new HourlyEmployeeNoIf(1),
                new HourlyEmployeeNoIf(2),
                new SalariedEmployeeNoIf(3),
                new HourlyEmployeeNoIf(4)
            };
        }

        public string generate()
        {
            var result = new StringBuilder();
            var visitor =  new EmployeeVisitor(result);
            foreach (var employee in employees)
            {
                employee.accept(visitor);
            }
            return result.ToString();
        } 
    }

    public abstract class EmployeeNoIf
    {
        protected int id; 
        
        public EmployeeNoIf(int id)
        {
            this.id = id;
        }

        public abstract void accept(EmployeeVisitor visitor);
    }

    public class HourlyEmployeeNoIf : EmployeeNoIf
    {
        public HourlyEmployeeNoIf(int id ) : base (id) { }

        public override void accept(EmployeeVisitor visitor)
        {
            visitor.visit(this);
        }

        public string reportQtdHours()
        {
            return string.Format("Worked hour for {0}", id );
        }
    }

    public class SalariedEmployeeNoIf : EmployeeNoIf
    {
        public SalariedEmployeeNoIf(int id ) : base (id) { }

        public override void accept(EmployeeVisitor visitor)
        {
            visitor.visit(this);
        }
    }

    public class EmployeeVisitor
    {
        private StringBuilder result;

        public  EmployeeVisitor(StringBuilder result)
        {
            this.result = result;
        }

        public void visit(HourlyEmployeeNoIf employee)
        {
            result.Append(employee.reportQtdHours());    
            result.Append("\n");    
        }

        public void visit(SalariedEmployeeNoIf employee)
        {
            
        }
    }
}