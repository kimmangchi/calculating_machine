using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculating_machine
{
    internal class calculate_dseok
    {
        // 변수는 앞에서 선언한 값을 활용할 것임

        // 제곱
        public double GetSquare_Value(double value)
        {
            double result = value * value;
            return result;
        }

        // 제곱근
        public double GetRoot_Value(double value)
        {
            double result = Math.Pow(value, 0.5);
            return result;

        }

        // 역수
        public double GetInverse_Value(double value)
        {
            if (value == 0)
            {
                MessageBox.Show("0으로 나누지 마세요!");
                return double.NaN;
            }
            else
            {
                double result = 1 / value;
                return result;
            }
        }

        // 퍼센트(%)
        public double GetPercentage_Value(double value)
        {
            double result = value / 100;
            return result;
        }
    }
}
