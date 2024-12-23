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
        string before_Value = "";
        string current_Value = "";
        string result_Value = "";

        public Form1()
        {
            InitializeComponent();
        }

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

        private void button_number0_Click(object sender, EventArgs e)
        {
            if(current_Value != "0" && current_Value != "")
            {
                current_Value += "0";
                textBox_presentvalue.Text = current_Value;
            }
        }



        private void button_ce_Click(object sender, EventArgs e)
        {
            current_Value = "";
            result_Value = "";
            before_Value = "";
            textBox_presentvalue.Text = current_Value;
        }

        private void button_c_Click(object sender, EventArgs e)
        {
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            current_Value = current_Value.Substring(0, current_Value.Length - 1);
            textBox_presentvalue.Text = current_Value;
        }


        private void button_add_Click(object sender, EventArgs e)
        {

        }
        private void button_subtract_Click(object sender, EventArgs e)
        {

        }

        private void button_multiple_Click(object sender, EventArgs e)
        {

        }
        private void button_divide_Click(object sender, EventArgs e)
        {

        }
        private void button_covertsign_Click(object sender, EventArgs e)
        {

        }
        private void button_percent_Click(object sender, EventArgs e)
        {

        }
        private void button_float_Click(object sender, EventArgs e)
        {

        }

        private void button_equal_Click(object sender, EventArgs e)
        {

        }

        
    }
}
