using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed_Class
{
    public sealed class GrandChild : Child
    {
        public new double Salary
        {
            get { return base.Salary; }
            set { base.Salary = value; }
        }

        public new void Print()
        {
            Console.WriteLine("I am GrandChild");
        }
    }
}
