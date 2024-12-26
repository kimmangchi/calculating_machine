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
    public struct CalculatorState
    {
        public string BeforeValue { get; set; }
        public string CurrentValue { get; set; }
        public string ResultValue { get; set; }
        public string Operation { get; set; }
        public bool IsEqualPressed { get; set; }
    }

    public partial class Form1 : Form
    {
        calculate cal = new calculate();
        CalculatorState state;

        public Form1()
        {
            InitializeComponent();
            state = new CalculatorState
            {
                BeforeValue = "",
                CurrentValue = "",
                ResultValue = "",
                Operation = "",
                IsEqualPressed = false
            };
        }

        private void UpdateDisplay()
        {
            textBox_presentvalue.Text = state.CurrentValue;
            textBox_prevalue.Text = $"{state.ResultValue} {state.Operation}";
        }

        private void AppendNumber(string number)
        {
            state.CurrentValue += number;
            UpdateDisplay();
        }

        private void button_number1_Click(object sender, EventArgs e) => AppendNumber("1");
        private void button_number2_Click(object sender, EventArgs e) => AppendNumber("2");
        private void button_number3_Click(object sender, EventArgs e) => AppendNumber("3");
        private void button_number4_Click(object sender, EventArgs e) => AppendNumber("4");
        private void button_number5_Click(object sender, EventArgs e) => AppendNumber("5");
        private void button_number6_Click(object sender, EventArgs e) => AppendNumber("6");
        private void button_number7_Click(object sender, EventArgs e) => AppendNumber("7");
        private void button_number8_Click(object sender, EventArgs e) => AppendNumber("8");
        private void button_number9_Click(object sender, EventArgs e) => AppendNumber("9");
        private void button_number0_Click(object sender, EventArgs e)
        {
            if (state.CurrentValue != "0")
            {
                AppendNumber("0");
            }
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            state.CurrentValue = "";
            textBox_presentvalue.Text = "";
            state.Operation = "";
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            state.CurrentValue = "";
            state.ResultValue = "";
            state.BeforeValue = "";
            state.Operation = "";
            textBox_presentvalue.Text = "";
            textBox_prevalue.Text = "";
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (state.CurrentValue.Length > 0)
            {
                state.CurrentValue = state.CurrentValue.Substring(0, state.CurrentValue.Length - 1);
                textBox_presentvalue.Text = state.CurrentValue;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (state.CurrentValue.Length != 0)
            {
                if (state.ResultValue == "")
                {
                    state.ResultValue = state.CurrentValue;
                }
                state.Operation = "+";
                state.CurrentValue = "";
                UpdateDisplay();
            }
        }
        private void button_subtract_Click(object sender, EventArgs e)
        {
            if (state.CurrentValue.Length == 0)
            {
                state.CurrentValue += "- ";
                textBox_presentvalue.Text = state.CurrentValue;
            } // 음수 입력 -10
            else
            {
                if (state.ResultValue == "")
                {
                    state.ResultValue = textBox_presentvalue.Text;
                }
                textBox_prevalue.Text = state.ResultValue + " - ";
                state.CurrentValue = "";
                textBox_presentvalue.Text = "";
                state.Operation = "-";
            } // 빼기
        }
        private void button_multiple_Click(object sender, EventArgs e)
        {
            if (state.CurrentValue.Length != 0)
            {
                if (state.ResultValue == "")
                {
                    state.ResultValue = textBox_presentvalue.Text;
                }
                textBox_prevalue.Text = state.ResultValue + " × ";
                state.CurrentValue = "";
                textBox_presentvalue.Text = "";
                state.Operation = "*";
            }
        }
        private void button_divide_Click(object sender, EventArgs e)
        {
            if (state.ResultValue == "")
            {
                state.ResultValue = textBox_presentvalue.Text;
            }
            state.CurrentValue = "";
            textBox_prevalue.Text = state.ResultValue + " ÷ ";
            textBox_presentvalue.Text = "";
            state.Operation = "/";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            switch (state.Operation)
            {
                case "+":
                    state.ResultValue = cal.addtion(state.ResultValue, state.CurrentValue);
                    state.CurrentValue = state.ResultValue;
                    state.Operation = "";
                    break;
                case "-":
                    state.ResultValue = cal.subtraction(state.ResultValue, state.CurrentValue);
                    state.CurrentValue = state.ResultValue;
                    state.Operation = "";
                    break;
                case "*":
                    state.ResultValue = cal.multiplication(state.ResultValue, state.CurrentValue);
                    state.CurrentValue = state.ResultValue;
                    state.Operation = "";
                    break;
                case "/":
                    state.ResultValue = cal.division(state.ResultValue, state.CurrentValue);
                    if (state.ResultValue == "∞")
                    {
                        state.CurrentValue = "0으로 나눌 수 없습니다.";
                        state.Operation = "";
                        state.ResultValue = "";
                    }
                    break;
            }
            UpdateDisplay();
        }

        private void button_float_Click(object sender, EventArgs e)
        {
            // 소수점은 하나만 있어야 한다.
            if (state.CurrentValue.IndexOf(".") == -1)
            {
                state.CurrentValue += ".";
            }
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            if (state.CurrentValue.Length != 0)
            {
                if (state.ResultValue == "")
                {
                    state.ResultValue = "0";
                    state.CurrentValue = "";
                    textBox_prevalue.Text = state.ResultValue;
                    textBox_presentvalue.Text = "";
                }
                else if (state.ResultValue != "")
                {
                    state.ResultValue = (double.Parse(state.ResultValue) / 100).ToString();
                    state.CurrentValue = "";
                    textBox_prevalue.Text = state.ResultValue;
                    textBox_presentvalue.Text = "";
                }

            }
        }

        private void button_covertsign_Click(object sender, EventArgs e)
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                state.CurrentValue = textBox_presentvalue.Text;
                double resConvert = double.Parse(state.CurrentValue) * -1;
                state.CurrentValue = resConvert.ToString();
                textBox_presentvalue.Text = state.CurrentValue;
            }
        }

        private void button_invert_Click(object sender, EventArgs e)
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                state.ResultValue = cal.GetInverse_Value(textBox_presentvalue.Text);
                state.CurrentValue = "";
                textBox_prevalue.Text = "1/(" + textBox_presentvalue.Text + ")";
                textBox_presentvalue.Text = state.ResultValue;
            }

            else if (textBox_presentvalue.Text.Length == 0)
            {
                textBox_presentvalue.Text = "0으로 나누지 마세요!";
                textBox_prevalue.Text = "1/0";
            }
        }

        private void button_spuare_Click(object sender, EventArgs e)
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                state.ResultValue = cal.GetSquare_Value(textBox_presentvalue.Text);
                textBox_prevalue.Text = "(" + textBox_presentvalue.Text + ")²";
                state.CurrentValue = "";
                textBox_presentvalue.Text = state.ResultValue;
            }
        }

        private void button_squareroot_Click(object sender, EventArgs e)
        {
            if (textBox_presentvalue.Text.Length != 0)
            {
                state.ResultValue = cal.GetRoot_Value(textBox_presentvalue.Text);
                if (state.ResultValue == "입력이 잘못되었습니다.")
                {
                    textBox_presentvalue.Text = state.ResultValue;
                    state.ResultValue = "";
                    textBox_prevalue.Text = "";
                }
                else
                {
                    state.CurrentValue = "";
                    textBox_prevalue.Text = "sqrt(" + textBox_presentvalue.Text + ")";
                    textBox_presentvalue.Text = state.ResultValue;
                }
            }

        }


    }
}

