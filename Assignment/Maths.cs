using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public static class Maths
    {
        public static int operationCount = 0;
        public static float Add(float a, float b)
        {
            operationCount++;
            return a + b;
        }
        public static float Subtract(float a, float b)
        {
            operationCount++;
            return a - b;
        }
        public static float Multiply(float a, float b)
        {
            operationCount++;
            return a * b;
        }
        public static float Divide(float a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            operationCount++;
            return (float)a / b;
        }
        public static float Power(float num, float pow)
        {
            for(int i = 1; i < pow; i++)
            {
                num *= num;
            }
            operationCount++;
            return num;
        }
        public static float Average(float[] arr)
        {
            float sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            operationCount++;
            return (float)sum / arr.Length;
        }
        public static void ShowOperationCount()
        {
           Console.WriteLine($"Total operations performed: {operationCount}");
        }
    }
}
