using Demo.Abstract_Classes;
using Demo.BuiltInInterface;
using Demo.Sealed_Class;
using Demo.Static_Class;

namespace Demo
{
    internal class Program
    {
        public static void ProcessShape(Shape shape)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
            Console.WriteLine($"Perimeter: {shape.Perimeter}");
            shape.PrintMessage();
        }
        static void Main(string[] args)
        {
            #region BuiltInInterface - ICloneable
            //Employee employee01 = new Employee
            //{
            //    Id = 1,
            //    Name = "John Doe",
            //    Salary = 50000
            //};
            //Employee employee02 = new Employee
            //{
            //    Id = 2,
            //    Name = "Jane Smith",
            //    Salary = 60000
            //};

            //Console.WriteLine(employee01);
            //Console.WriteLine($"Hachcode for employee01 => {employee01.GetHashCode()}");
            //Console.WriteLine(employee02);
            //Console.WriteLine($"Hachcode for employee02 => {employee02.GetHashCode()}");

            ////employee02 = (Employee)employee01.Clone();
            //employee02 = new Employee(employee01);
            //Console.WriteLine("After cloning employee01 to employee02:");

            //Console.WriteLine(employee01);
            //Console.WriteLine($"Hachcode for employee01 => {employee01.GetHashCode()}");
            //Console.WriteLine(employee02);
            //Console.WriteLine($"Hachcode for employee02 => {employee02.GetHashCode()}");




            #endregion

            #region BuiltInInterface - IComparable, IComparer
            //Employee[] employees =
            //{
            //   new Employee() { Id = 1, Name = "John Doe", Salary = 50000},
            //   new Employee() { Id = 2, Name = "Jane Smith", Salary = 60000 },
            //   new Employee() { Id = 3, Name = "Alice Johnson", Salary = 55000},
            //   new Employee() { Id = 4, Name = "Bob Brown", Salary = 70000},

            //};

            //Array.Sort(employees, new EmployeeNameComparer());
            //Array.Sort(employees, new EmployeeIdComparer());

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}


            #endregion

            #region abstract Class
            //Triangle triangle = new Triangle(10, 20, 30);
            //ProcessShape(triangle);

            //Rectangle rectangle = new Rectangle
            //{
            //    Dim01 = 10,
            //    Dim02 = 20
            //};
            //ProcessShape(rectangle);

            //Square square = new Square(6);
            //ProcessShape(square);
            #endregion

            #region Static Class
            //static
            // 1. cannot take instance from static class
            // 2. contains static members only (methods, properties, fields, constructor, event, constant)
            // 3. cannot be inherited
            // 4. use its members without creating an instance

            //Utility utility = new Utility(50,70);
            //var result = Utility.CalculateCircleArea(50);
            //Console.WriteLine(result);
            #endregion

            #region Sealed Class
            //GrandChild grandChild = new GrandChild();
            #endregion

            #region Partial Class

            #endregion

        }
    }
}
