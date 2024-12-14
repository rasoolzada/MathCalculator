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
        char op;
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "1";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "1";
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 12)
            {
                textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, 20);
            }
            if (textBox1.Text.Length > 20)
            {
                this.textBox1.Text = "Max Limit Exceeded!";
                this.textBox1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox1.Text = "0";
            this.textBox2.Text= "0";
            this.textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, 30);
            this.textBox1.ForeColor= System.Drawing.Color.Black;
            this.button13.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "2"; 
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "2";
            }
        }
        double n1;
        private void button9_Click(object sender, EventArgs e)
        {
            op = '+';
            double.TryParse(this.textBox1.Text, out n1);
            this.textBox2.Text = this.textBox1.Text + " + ";
            this.textBox1.ResetText();
            this.textBox1.Text = "0";
        }
        private void button13_Click(object sender, EventArgs e)
        {
                
                double n2;
                double r;
                double.TryParse(textBox1.Text, out n2);

            if (op == '+')
            {
                r = n1 + n2;

                this.textBox2.Text += this.textBox1.Text;

                this.textBox1.Text = r.ToString();
                this.button13.Enabled = false;
            }
            if (op == '-')
            {
                r = n1 - n2;

                this.textBox2.Text += this.textBox1.Text;

                this.textBox1.Text = r.ToString();
                this.button13.Enabled = false;
            }
            if (op == 'x')
            {
                r = n1 * n2;

                this.textBox2.Text += this.textBox1.Text;

                this.textBox1.Text = r.ToString();
                this.button13.Enabled = false;
            }
            if (op == '/')
            {
                r = n1 / n2;

                this.textBox2.Text += this.textBox1.Text;

                this.textBox1.Text = r.ToString();
                this.button13.Enabled = false;
            }
            if (op == '%')
            {
                r = n1 % n2;

                this.textBox2.Text += this.textBox1.Text;

                this.textBox1.Text = r.ToString();
                this.button13.Enabled = false;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "3";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "4";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "5";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "6";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "7";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "8";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = "9";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text!="0")
            {
                this.textBox1.Text+="0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            op = '-';
            double.TryParse(this.textBox1.Text, out n1);
            this.textBox2.Text = this.textBox1.Text + " - ";
            this.textBox1.ResetText();
            this.textBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = 'x';
            double.TryParse(this.textBox1.Text, out n1);
            this.textBox2.Text = this.textBox1.Text + " x ";
            this.textBox1.ResetText();
            this.textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op = '/';
            double.TryParse(this.textBox1.Text, out n1);
            this.textBox2.Text = this.textBox1.Text + " / ";
            this.textBox1.ResetText();
            this.textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            op = '%';
            double.TryParse(this.textBox1.Text, out n1);
            this.textBox2.Text = this.textBox1.Text + " % ";
            this.textBox1.ResetText();
            this.textBox1.Text = "0";
        }
    }
}
