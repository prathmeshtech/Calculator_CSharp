using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
        string option;
        int res;
        string CalculatorRes;
        List<string> historyList = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + btn1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + btn7.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + btn0.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + btn3.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + btn4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + btn9.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<historyList.Count(); i++)
            {
                //textBoxDisplay.Text = historyList[i] + textBoxDisplay.Text + Environment.NewLine;
                textBoxDisplay.AppendText(historyList[i]);
                textBoxDisplay.AppendText(Environment.NewLine);
            }
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + btn6.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + btn5.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + btn2.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + btn8.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            option = "%";
            num1 = int.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();
        }

        private void btnEqua_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBoxDisplay.Text); 

            if(option == ("+"))
            {
                res = num1 + num2;
                historyList.Add(num1.ToString() + "+" + num2.ToString() + "=" + res.ToString());
            }
            else if (option == ("-"))
            {
                res = num1 - num2;
                historyList.Add(num1.ToString() + "-" + num2.ToString() + "=" + res.ToString());
            }
            else if (option == ("*"))
            {
                res = num1 * num2;
                historyList.Add(num1.ToString() + "*" + num2.ToString() + "=" + res.ToString());
            }
            else if (option == ("/"))
            {
                res = num1 / num2;
                historyList.Add(num1.ToString() + "/" + num2.ToString() + "=" + res.ToString());
            }
            else if (option == ("%"))
            {
                res = num1 % num2;
                historyList.Add(num1.ToString() + "%" + num2.ToString() + "=" + res.ToString());
            }

            textBoxDisplay.Text = (res + "");
        }
    }
}
