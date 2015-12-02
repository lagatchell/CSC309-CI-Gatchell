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
        double num1 = 0
                , num2 = 0
                , ans = 0;
        double value = 0;
        char op = '+';    
           
        bool whichNum = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            
            if (whichNum == false)
            {
                answer.AppendText("1");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText("1");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2);
            }
            
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (whichNum == false)
            {
                answer.AppendText("2");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText("2");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2); 
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (whichNum == false)
            {
                answer.AppendText("3");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText("3");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2); 
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (whichNum == false)
            {
                answer.AppendText("4");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText("4");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2); 
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (whichNum == false)
            {
                answer.AppendText("5");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText("5");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2); 
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (whichNum == false)
            {
                answer.AppendText("6");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText("6");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2); 
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (whichNum == false)
            {
                answer.AppendText("7");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText("7");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2); 
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (whichNum == false)
            {
                answer.AppendText("8");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText("8");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2); 
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (whichNum == false)
            {
                answer.AppendText("9");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText("9");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2); 
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (whichNum == false)
            {
                answer.AppendText("0");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText("0");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2);
            }
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if (answer.Text.ToString() == "")
            {
                answer.AppendText("0");
                whichNum = true;
                op = '-';
            }
            else if (whichNum == false)
            {
                whichNum = true;
                op = '-';
            }
            else
            {
                op = '-';
            }
            answer.AppendText(" - ");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (answer.Text.ToString() == "")
            {
                answer.AppendText("1");
                num1 = 1;
                whichNum = true;
                op = '/';
            }
            else if (whichNum == false)
            {
                whichNum = true;
                op = '/';
            }
            else
            {
                op = '/';
            }
            answer.AppendText(" / ");
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (answer.Text.ToString() == "")
            {
                answer.AppendText("0");
                whichNum = true;
                op = '+';
            }
            else if (whichNum == false)
            {
                whichNum = true;
                op = '+';
            }
            else
            {
                op = '+';
            }
            answer.AppendText(" + ");
            

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (answer.Text.ToString() == "")
            {
                answer.AppendText("1");
                num1 = 1;
                whichNum = true;
                op = '*';
            }
            else if (whichNum == false)
            {
                whichNum = true;
                op = '*';
            }
            else
            {
                op = '*';
            }
            answer.AppendText(" * ");
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (whichNum == true)
            {
                whichNum = false;
                if (op == '+')
                {
                    ans = num1 + num2;
                    answer.Text = ans.ToString();
                    num1 = ans;
                    whichNum = true;
                }
                if (op == '-')
                {
                    ans = num1 - num2;
                    answer.Text = ans.ToString();
                    num1 = ans;
                    whichNum = true;
                }
                if (op == '*')
                {
                    ans = num1 * num2;
                    answer.Text = ans.ToString();
                    num1 = ans;
                    whichNum = true;
                }
                if (op == '/')
                {
                    ans = num1 / num2;
                    answer.Text = ans.ToString();
                    num1 = ans;
                    whichNum = true;
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            answer.Clear();
            value = 0;
            num1 = 0;
            num2 = 0;
            whichNum = false;
        }

        private void period_Click(object sender, EventArgs e)
        {
            if (whichNum == false)
            {
                answer.AppendText(".");
                value = Convert.ToDouble(answer.Text);
                num1 = value;
            }
            else
            {
                string hold = num1.ToString() + " " + op.ToString();
                answer.AppendText(".");
                string hold2 = answer.Text.Replace(hold, "");
                num2 = Convert.ToDouble(hold2);
            }
        }
    }
}
