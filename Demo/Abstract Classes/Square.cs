using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstract_Classes
{
    public class Square : RecBase, IDraw
    {
        public Square(decimal side)
        {
            Dim01 = Dim02 = side;
        }
        public override decimal Perimeter
        {
            get
            {
                return  Dim01 * 4;
            }
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
