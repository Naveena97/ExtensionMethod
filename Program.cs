using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodTask
{
    public static class Program
    {

        public static string ExtensionMethod(this String input)
        {
            string result = input;


            if (input.Any(char.IsDigit))
            {
                result = "$" + input.ToString();

            }
            else
            {
                throw new InvalidOperationException("Invaild input");

            }
            return result;

        }
        public static void Main()
        {
            String y = "hello123";
            String x = "hello";

            Console.WriteLine(y.ExtensionMethod());

            Console.WriteLine(x.ExtensionMethod());
        }
    }
}