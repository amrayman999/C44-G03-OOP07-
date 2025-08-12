using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial_Class
{
    public partial class Employee
    {
        internal partial void Print()
        {
            Console.WriteLine("Hello");
        }

    }
}
