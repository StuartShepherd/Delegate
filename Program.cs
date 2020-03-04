using System;

namespace Delegate
{
    class Program
    {
        public delegate double MathDelegate(double value1, double value2);

        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        public static double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Delegate");
            Console.WriteLine("A delegate is a type that defines a method signature. You can invoke the method through the delegate.");
            Console.WriteLine();

            // output result is 7      
            MathDelegate mathAddDelegate = Add;
            Console.WriteLine(mathAddDelegate(5, 2));

            // output result is 3
            MathDelegate mathSubtractDelegate = Subtract;
            Console.WriteLine(mathSubtractDelegate(5, 2));           

            Console.ReadLine();
        }
    }
}