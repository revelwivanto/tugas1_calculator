using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas1_calculator
{
    public partial class Form1 : Form
    {
        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textBox.Text);

            textBox.Clear();
        }

        private void buttonsubtract_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textBox.Text);

            textBox.Clear();
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            option = "x";
            num1 = int.Parse(textBox.Text);

            textBox.Clear();
        }

        private void buttondiversify_Click(object sender, EventArgs e)
        {
            option = ":";
            num1 = int.Parse(textBox.Text);

            textBox.Clear();
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("x"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            textBox.Text = result + "";
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
