using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed_Class
{
    public class Child : Parent
    {
        public sealed override double Salary { get => base.Salary; set => base.Salary = value; }
        public sealed override void Print()
        {
            Console.WriteLine("I am Child");
        }
    }
}
