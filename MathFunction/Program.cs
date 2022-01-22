using System;

namespace MathFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathFunc mathFunc = new MathFunc(1, -4, 3);
            Console.WriteLine(mathFunc.RunCalculating());
        }
    }

    public class MathFunc
    {
        double a, b, c, x1, x2, delta, sqrtFromDelta;

        

        public MathFunc(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string RunCalculating()
        {
            delta = GetDelta();
            sqrtFromDelta = GetSqrtFromDelta();

            return Result;
        }


        public double GetDelta()
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }

        private double GetSqrtFromDelta()
        {
            return Math.Sqrt(delta);
        }

        private string Result =>
            delta switch
            {
                0 => GetX0(),
                (> 0) => GetX1AndX2(),
                (<0) => "No results",
            };

        private string GetX0()
        {
            double result = (-b) / (2 * a);
            return $"The result is x1 = {result}";
        }

        private string GetX1AndX2()
        {
            x1 = (-b + sqrtFromDelta) / 2 * a;
            x2 = (-b +- sqrtFromDelta) / 2 * a;

            return $"The result is x1 = {x1}, and x2 = {x2}";
        }
        
    }
}
