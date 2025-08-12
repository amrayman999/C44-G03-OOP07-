using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstract_Classes
{
    public class Triangle : Shape
    {
        public decimal Dim03 { get; set; }
        public Triangle(decimal dim01 , decimal dim02, decimal dim03) : base(dim01, dim02)
        {
            Dim03 = dim03;
        }

        public override decimal Perimeter
        {
            get
            {
                return Dim01 + Dim02 + Dim03;
            }
        }

        public override decimal CalculateArea()
        {
            return 0.5m * Dim03 * Dim02 * Dim01;
        }
    }
}
