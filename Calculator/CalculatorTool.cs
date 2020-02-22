using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class CalculatorTool
    {

        public CalculatorTool()
        {
        }

        public static double CalculateExpression(String ex)
        {
            string[] result = Regex.Split(ex, @"(?=[\^*+\-\/])|(?<=[\^*+\-\/])");
            foreach (String s in result) Console.WriteLine(s);
            return 1f;
        }
    }
}
