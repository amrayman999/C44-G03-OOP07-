using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuiltInInterface
{
    public class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }
        public Employee()
        {
            
        }
        public object Clone()
        {
            return new Employee(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary:C}";
        }
        public int CompareTo(object? obj)
        {
            Employee employee = (Employee)obj;
            if (this.Salary > employee.Salary)
            {
                return -1;
            }
            else if (this.Salary < employee.Salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
