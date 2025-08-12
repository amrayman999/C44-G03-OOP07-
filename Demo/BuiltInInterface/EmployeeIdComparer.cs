using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuiltInInterface
{
    public class EmployeeIdComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x?.Id.CompareTo(y?.Id) ?? 0;
        }
    }
}
