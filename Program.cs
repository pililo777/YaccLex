using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lenguaje
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            Calculator.CalculatorParser calc = new Calculator.CalculatorParser();

            calc.Parse("(1+2)*4");

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
