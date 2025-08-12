using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstract_Classes
{
    // cannot create instance from abstract class
    // can implement interface
    // can inherit from another class
    public abstract class Shape 
    {
        // Concrete Properties
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        protected Shape()
        {
            
        }
        protected Shape(decimal dim01, decimal dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }

        // Abstract Property
        public abstract decimal Perimeter { get; }

        // Abstract method 
        public abstract decimal CalculateArea();

        // Non Abstract method  - COncrete method
        public void PrintMessage()
        {
            Console.WriteLine("I am Shape");
        }


    }
}
