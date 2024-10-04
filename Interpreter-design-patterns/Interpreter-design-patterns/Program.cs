using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression expression = new AdditionExpression(new NumberExpression(1), new NumberExpression(2));

            int result = expression.Interpret();
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}
