using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculating_machine
{
    class Four_Basic_Operation
    {
        public double addtion(string x, string y)
        {
            return double.Parse(x) + double.Parse(x);
        }

        public double subtraction(string x, string y)
        {
            return double.Parse(x) - double.Parse(x);
        }

        public double division(string x, string y)
        {
            return double.Parse(x) / double.Parse(x);
        }

        public double multiplication(string x, string y)
        {
            return double.Parse(x) * double.Parse(x);
        }

    }
}
