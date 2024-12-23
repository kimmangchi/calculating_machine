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
        double textBox_prevalue;
        double textBox_presentvalue;
        // double result_Value;
        public Form1()
        {
            InitializeComponent();
        }

        calculate_dseok cal_dseok = new calculate_dseok();

        private void button_Square_Click(object sender, EventArgs e)
        {
            textBox_prevalue = Convert.ToDouble(textBox_Input.Text);
            textBox_presentvalue = cal_dseok.GetSquare_Value(textBox_prevalue);
            textBox_Result.Text = textBox_presentvalue.ToString();
        }

        private void button_Root_Click(object sender, EventArgs e)
        {
            textBox_prevalue = Convert.ToDouble(textBox_Input.Text);
            textBox_presentvalue = cal_dseok.GetRoot_Value(textBox_prevalue);
            textBox_Result.Text = textBox_presentvalue.ToString(); // 소숫점 계산이 문제임ㄴ
        }

        private void button_Inverse_Click(object sender, EventArgs e)
        {
            textBox_prevalue = Convert.ToDouble(textBox_Input.Text);
            textBox_presentvalue = cal_dseok.GetInverse_Value(textBox_prevalue);
            textBox_Result.Text = textBox_presentvalue.ToString(); // 소숫점 계산이 문제임
        }

        private void button_Percentage_Click(object sender, EventArgs e)
        {
            textBox_prevalue = Convert.ToDouble(textBox_Input.Text);
            textBox_presentvalue = cal_dseok.GetPercentage_Value(textBox_prevalue);
            textBox_Result.Text = textBox_presentvalue.ToString(); // 소숫점 계산이 문제임
        }
    }
}
