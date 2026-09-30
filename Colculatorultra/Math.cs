using System;

namespace Calcylatorultra
{
    public class Math
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b) {
            return a - b;
        }
        public double Multiply(double a, double b) {
            return a * b;

        }
        public double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                return 0;
            }
        }
        public long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i < n + 1; i+=1)
            {
                result = result * i;
            }
            return result;
        }

        public int Mod(int a, int b)
        {
            return a % b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        public double Percent(double num, double prc)
        {
           return (num * prc) / 100;
        } 
        public double DPercent(double first, double second)
        {
            if (second != 0)
            {
                return (first / second) * 100;
            }
            else
            {
                return 0;
            }
        } 
    }
}