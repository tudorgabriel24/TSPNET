using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        string usedOperator = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Clear();
            usedOperator = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(textBox1.Text);
            switch (usedOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/": 
                    result = firstNumber / secondNumber;
                    break;
                default: break;
                
            }
            textBox1.Text = result.ToString();
            firstNumber = result;
            secondNumber = 0;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Clear();
            usedOperator = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Clear();
            usedOperator = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Clear();
            usedOperator = "+";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "9";
        }
    }
}
