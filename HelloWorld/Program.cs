using System;

namespace HelloWorld
{
    internal class ProgramThatMakesDiffrentThings
    {
        public static void Main(string[] args)
        {
            double a = 20;
            double b = 10;

            Math math = new Math();

            double addResult = math.Add(a, b);
            double substractResult = math.Subtract(a, b);

            Console.WriteLine(addResult.ToString());
            Console.WriteLine(substractResult.ToString());
            Console.Write(addResult.ToString());
        }
    }
}