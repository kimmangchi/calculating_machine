using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculating_machine
{
    public partial class Form1 : Form
    {
        calculate cal = new calculate();
        string before_Value = "";
        string current_Value = "";
        string result_Value = "";
        string operation = "";

        bool isEqualPressed = false;
        public Form1()
        {
            InitializeComponent();
        }
        /// 넘패드 숫자 입력

        private void button_number1_Click(object sender, EventArgs e)
        {
            current_Value += "1";
            textBox_presentvalue.Text = current_Value;
        }

        private void button_number2_Click(object sender, EventArgs e)
        {
            current_Value += "2";
            textBox_presentvalue.Text = current_Value;
        }

        private void button_number3_Click(object sender, EventArgs e)
        {
            current_Value += "3";
            textBox_presentvalue.Text = current_Value;
        }

        private void button_number4_Click(object sender, EventArgs e)
        {
            current_Value += "4";
            textBox_presentvalue.Text = current_Value;
        }

        private void button_number5_Click(object sender, EventArgs e)
        {
            current_Value += "5";
            textBox_presentvalue.Text = current_Value;
        }

        private void button_number6_Click(object sender, EventArgs e)
        {
            current_Value += "6";
            textBox_presentvalue.Text = current_Value;
        }

        private void button_number7_Click(object sender, EventArgs e)
        {
            current_Value += "7";
            textBox_presentvalue.Text = current_Value;
        }

        private void button_number8_Click(object sender, EventArgs e)
        {
            current_Value += "8";
            textBox_presentvalue.Text = current_Value;
        }

        private void button_number9_Click(object sender, EventArgs e)
        {
            current_Value += "9";
            textBox_presentvalue.Text = current_Value;
        }

        // 0을 추가할 때는 0123 이런 경우 방지를 위한 예외 처리를 한다.
        private void button_number0_Click(object sender, EventArgs e)
        {
            if (current_Value != "0")
            {
                current_Value += "0";
                textBox_presentvalue.Text = current_Value;
            }
        }
        /// 넘패드 입력
        private void button_ce_Click(object sender, EventArgs e)
        {
            current_Value = "";
            result_Value = "";
            before_Value = "";
            operation = "";
            textBox_presentvalue.Text = "";
            textBox_prevalue.Text = "";
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            current_Value = "";
            textBox_presentvalue.Text = "";
            operation = "";
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (current_Value.Length > 0)
            {
                current_Value = current_Value.Substring(0, current_Value.Length - 1);
                textBox_presentvalue.Text = current_Value;
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (current_Value.Length != 0)
            {
                if (result_Value == "")
                {
                    result_Value = textBox_presentvalue.Text;
                }
                textBox_prevalue.Text = result_Value + "+";
                current_Value = "";
                textBox_presentvalue.Text = "";
                operation = "+";
            }
        }
        private void button_subtract_Click(object sender, EventArgs e)
        {
            if (current_Value.Length == 0)
            {
                current_Value += "-";
                textBox_presentvalue.Text = current_Value;
            } // 음수 입력 -10
            else
            {
                if (result_Value == "")
                {
                    result_Value = textBox_presentvalue.Text;
                }
                textBox_prevalue.Text = result_Value + "-";
                current_Value = "";
                textBox_presentvalue.Text = "";
                operation = "-";
            } // 빼기
        }

        private void button_multiple_Click(object sender, EventArgs e)
        {
            if (current_Value.Length != 0)
            {
                if (result_Value == "")
                {
                    result_Value = textBox_presentvalue.Text;
                }
                textBox_prevalue.Text = result_Value + "x";
                current_Value = "";
                textBox_presentvalue.Text = "";
                operation = "*";
            }
        }
        private void button_divide_Click(object sender, EventArgs e)
        {
            if (result_Value == "")
            {
                result_Value = textBox_presentvalue.Text;
            }
            current_Value = "";
            textBox_prevalue.Text = result_Value + "/";
            textBox_presentvalue.Text = "";
            operation = "/";
        }
        // --------------------------------------------------------
        private void button_covertsign_Click(object sender, EventArgs e)
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                current_Value = textBox_presentvalue.Text;
                double resConvert = double.Parse(current_Value) * -1;
                current_Value = resConvert.ToString();
                textBox_presentvalue.Text = current_Value;
            }
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            if (current_Value.Length != 0)
            {
                if (result_Value == "")
                {
                    result_Value = cal.GetPercentage_Value(textBox_presentvalue.Text);
                    current_Value = "";
                    textBox_prevalue.Text = result_Value;
                    textBox_presentvalue.Text = "";
                }
                else if (result_Value != "")
                {
                    result_Value = (double.Parse(result_Value) / 100).ToString();
                    current_Value = "";
                    textBox_prevalue.Text = result_Value;
                    textBox_presentvalue.Text = "";
                }

            }
        }

        private void button_invert_Click(object sender, EventArgs e)
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                if (result_Value != "")
                {
                    result_Value = cal.GetInverse_Value(textBox_presentvalue.Text);
                    if (result_Value == "0으로 나누지 마세요!")
                    {
                        textBox_presentvalue.Text = result_Value;
                        result_Value = "";
                        textBox_prevalue.Text = "";
                    }
                    else
                    {
                        current_Value = "";
                        textBox_prevalue.Text = "1/("+ textBox_presentvalue.Text+")";
                        textBox_presentvalue.Text = result_Value;
                    }
                }
            }
        }

        private void button_spuare_Click(object sender, EventArgs e)
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                result_Value = cal.GetSquare_Value(textBox_presentvalue.Text);
                textBox_prevalue.Text = "sqrt(" + textBox_presentvalue.Text + ")";
                current_Value = "";
                textBox_presentvalue.Text = result_Value;
            }
        }

        private void button_squareroot_Click(object sender, EventArgs e)
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                if (result_Value == "")
                {
                    result_Value = cal.GetRoot_Value(textBox_presentvalue.Text);
                    if (result_Value == "입력이 잘못되었습니다.")
                    {
                        textBox_presentvalue.Text = result_Value;
                        result_Value = "";
                        textBox_prevalue.Text = "";
                    }
                    else
                    {
                        current_Value = "";
                        textBox_prevalue.Text = result_Value;
                        textBox_presentvalue.Text = "";
                    }
                }

            }
        }

        private void button_float_Click(object sender, EventArgs e)
        {
            // 소수점은 하나만 있어야 한다.
            if (current_Value.IndexOf(".") == -1)
            {
                current_Value += ".";
            }
        }
        private void button_equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+": // 더하기
                    if (current_Value == "") break; // 연산자가 비어있는 경우
                    textBox_presentvalue.Text = ""; // 현재 입력 값 삭제
                    result_Value = cal.addtion(result_Value, current_Value);
                    if (textBox_prevalue.Text[textBox_prevalue.Text.Length - 1] != '+')
                    {
                        textBox_prevalue.Text = (result_Value + "+" + current_Value);
                    }
                    else
                    {
                        textBox_prevalue.Text += current_Value;
                    }
                    textBox_presentvalue.Text = result_Value;
                    break;

                case "-": // 빼기
                    if (current_Value == "") break;
                    if (textBox_prevalue.Text[textBox_prevalue.Text.Length - 1] != '-')
                    {
                        textBox_prevalue.Text = (result_Value + "-" + current_Value);
                    }
                    else
                    {
                        textBox_prevalue.Text += current_Value;
                    }
                    textBox_presentvalue.Text = "";
                    result_Value = cal.subtraction(result_Value, current_Value);
                    textBox_presentvalue.Text = result_Value;
                    operation = "";
                    break;
                case "*": // 곱하기
                    if (current_Value == "") break;
                    if (textBox_prevalue.Text[textBox_prevalue.Text.Length - 1] != 'x')
                    {
                        textBox_prevalue.Text = (result_Value + "x" + current_Value);
                    }
                    else
                    {
                        textBox_prevalue.Text += current_Value;
                    }
                    textBox_presentvalue.Text = "";
                    result_Value = cal.multiplication(result_Value, current_Value);
                    textBox_presentvalue.Text = result_Value;
                    operation = "";
                    break;
                case "/": // 나누기
                    if (current_Value == "") break;
                    if (textBox_prevalue.Text[textBox_prevalue.Text.Length - 1] != '/')
                    {
                        textBox_prevalue.Text = (result_Value + "/" + current_Value);
                    }
                    else
                    {
                        textBox_prevalue.Text += current_Value;
                    }
                    textBox_presentvalue.Text = "";
                    result_Value = cal.division(result_Value, current_Value);
                    textBox_presentvalue.Text = result_Value;
                    operation = "";
                    break;
            }
        }
    }
}
