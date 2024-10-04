using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_design_patterns
{
    class NumberExpression : Expression
    {
        private int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public override int Interpret()
        {
            return number;
        }
    }
}
