using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculating_machine
{
    class calculate
    {
        //더하기
        public double addtion(string x, string y)
        {
            return double.Parse(x) + double.Parse(y);
        }

        //빼기
        public double subtraction(string x, string y)
        {
            return double.Parse(x) - double.Parse(y);
        }

        //나누기
        public double division(string x, string y)
        {
            return double.Parse(x) / double.Parse(y);
        }

        //곱하기
        public double multiplication(string x, string y)
        {
            return double.Parse(x) * double.Parse(y);
        }

        // 제곱
        public double GetSquare_Value(string x)
        {
            return double.Parse(x) * double.Parse(x);
        }

        // 제곱근
        public double GetRoot_Value(string x)
        {
            double result = Math.Pow(double.Parse(x), 0.5);
            return result;

        }

        // 역수
        public double GetInverse_Value(string x)
        {
            if (double.Parse(x) == 0)
            {
                return double.NaN;
            }
            else
            {
                double result = 1 / double.Parse(x);
                return result;
            }
        }

        // 퍼센트(%)
        public double GetPercentage_Value(string x)
        {
            double result = double.Parse(x) / 100;
            return result;
        }

    }
}
