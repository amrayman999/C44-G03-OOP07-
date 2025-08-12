using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed_Class
{
    public class Parent
    {
        private double salary;
        public virtual double Salary
        {
            get { return salary; }
            set { salary = value;}
        }

        public virtual void Print()
        {
           Console.WriteLine("I am Parent");
        }
    }
}
