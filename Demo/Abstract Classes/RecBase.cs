using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstract_Classes
{
    public abstract class RecBase : Shape
    {
        public override decimal CalculateArea()
        {
            return Dim01 * Dim02;
        }
    }
}
