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

            double res = Double.Parse(result[0]);
            for (int i = 1; i < result.Length - 1; i += 2)
            {

                switch (result[i])
                {
                    case "+":
                        res = res + Double.Parse(result[i + 1]);
                        break;
                    case "-":
                        res = res - Double.Parse(result[i + 1]);
                        break;
                    case "/":
                        res = res / Double.Parse(result[i + 1]);
                        break;
                    case "*":
                        res = res * Double.Parse(result[i + 1]);
                        break;
                    default://^
                        res = (Math.Pow(res, Double.Parse(result[i + 1])));
                        break;
                }
            }
            return res;
        }
           
        
    }
}
