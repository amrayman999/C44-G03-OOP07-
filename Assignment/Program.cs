namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int continueChoice = 1;
            do
            {
                Console.WriteLine("Welcome to the Maths Operations Program!");
                Console.WriteLine("Choose an operation: Add, Subtract, Multiply, Divide, Power, Average");
                string operation = Console.ReadLine().ToLower();
                float num1 = 0, num2 = 0, result = 0;
                if (operation != "average")
                {
                    Console.WriteLine("Please enter two numbers:");
                    num1 = float.Parse(Console.ReadLine());
                    num2 = float.Parse(Console.ReadLine());
                    result = 0;
                }
                switch (operation)
                {
                    case "add":
                        result = Maths.Add(num1, num2);
                        break;
                    case "subtract":
                        result = Maths.Subtract(num1, num2);
                        break;
                    case "multiply":
                        result = Maths.Multiply(num1, num2);
                        break;
                    case "divide":
                        try
                        {
                            result = Maths.Divide(num1, num2);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                        break;
                    case "power":
                        result = Maths.Power(num1, num2);
                        break;
                    case "average":
                        Console.WriteLine("Enter the number of elements for average calculation:");
                        int count = int.Parse(Console.ReadLine());
                        float[] numbers = new float[count];
                        Console.WriteLine("Enter the numbers:");
                        for (int i = 0; i < count; i++)
                        {
                            numbers[i] = float.Parse(Console.ReadLine());
                        }
                        result = Maths.Average(numbers);
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        break;
                }
                Console.WriteLine($"The result of {operation} is: {result}");
                Console.Write("Do you want to do another operation ? (1 for Yes, 0 for No): ");
                continueChoice = int.Parse(Console.ReadLine()); 
            } while (continueChoice == 1);
            Console.WriteLine($"Total operations performed: {Maths.operationCount}");

        }
    }
}
