using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static_Class
{
    // static class cannot be instantiated
    // static class can only contain static members (methods, properties, fields, etc.)
    // static class cannot have instance members
    // static class is used to group related utility methods or properties that do not require an instance of the class.
    // static class is often used for utility functions, constants, or helper methods that are not tied to a specific instance.
    // static class cannot inherit from another class or be inherited by another class.
    // static class cannot implement interfaces.
    public static class Utility
    {
        //public static int X { get; set; }
        //public static int Y { get; set; }

        //public Utility(int x , int y)
        //{
        //    X = x;
        //    Y = y;
        //}

        // Static constructor
        // 1. It is called only once, when the class is first accessed.
        // 2. It cannot take parameters.
        // 3. It is used to initialize static members of the class.
        // 4. It is called before any static members are accessed or any instance of the class is created.
        // 5. It cannot be called directly.
        // 6. It is useful for setting up any static state or configuration that the class needs.
        // 7. It is executed before any instance constructor.
        static Utility()
        {

        }

        public static double MeterToCm(double value)
        {
            return value * 100;
        }
        private const double pi = 3.14;

        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
