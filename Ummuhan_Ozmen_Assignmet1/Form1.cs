using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ummuhan_Ozmen_Assignmet1
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char operation;
        double result = 0.0;
        string ınput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";
            ınput += "1";
            displayButton.Text += ınput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";
            ınput += "2";
            displayButton.Text += ınput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";
            ınput += "3";
            displayButton.Text += ınput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";
            ınput += "4";
            displayButton.Text += ınput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";
            ınput += "5";
            displayButton.Text += ınput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";
            ınput += "6";
            displayButton.Text += ınput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";
            ınput += "7";
            displayButton.Text += ınput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";
            ınput += "8";
            displayButton.Text += ınput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";
            ınput += "9";
            displayButton.Text += ınput;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";

            if (displayButton.Text == "0")
            {
                displayButton.Text = "0";
            }
            else
            {
                ınput += "0";
                displayButton.Text += ınput;
            }
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            displayButton.Text = "";
            ınput += ",";
            displayButton.Text += ınput;

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

            second = ınput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (operation == '+')
            {
                result = firstNum + secondNum;
                displayButton.Text = result.ToString() ; 
               

            }
            else if (operation == '-')
            {
                result = firstNum - secondNum;
                displayButton.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = firstNum * secondNum;
                displayButton.Text = result.ToString();
            }
            else if (operation == '/')
            {
                result = firstNum / secondNum;
                displayButton.Text = result.ToString();

            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operation = '/';
            first = ınput;
            ınput = "";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            operation = '*';
            first = ınput;
            ınput = "";
        }

        private void buttonSubtruction_Click(object sender, EventArgs e)
        {
            operation = '-';
            first = ınput;
            ınput = "";
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            operation = '+';
            first = ınput;
            ınput = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            first = "";
            second = "";
            ınput = "";
            result = 0.0;
            displayButton.Text = "0";

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(displayButton.Text) > 0)
            {
                displayButton.Text = displayButton.Text.Remove(displayButton.Text.Length - 1, 1);
                if (displayButton.Text.Length == 0)
                {
                    displayButton.Text = "0";
                    ınput = "";
                }
                if (displayButton.Text.EndsWith(","))
                {
                    displayButton.Text = displayButton.Text.Remove(displayButton.Text.Length - 1, 1);
                }
            }
        }
    }
}
