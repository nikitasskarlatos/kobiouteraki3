using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculation
{
    public partial class Form1 : Form
    {
        double FirstNumber,count=0;  
	        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
           FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
                { e.Handled = true; }

        }

        private void action_Click(object sender, EventArgs e)
        {
            double SecondNumber;
                            double Result;
            
SecondNumber = Convert.ToDouble(textBox1.Text);
            
                if (Operation == "+")
                                {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                                }
                            if (Operation == "-")
                                {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                                }
                            if (Operation == "*")
                                {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                
                                }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Division by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;

                }
            }
                            if (Operation == "square root")
                                {
                    
                    
                    Result = Math.Sqrt(FirstNumber);
                    
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                
            }
                            if (Operation=="square")
            {
                Result = Math.Pow(FirstNumber, SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
                                    
                               

        }

        private void add9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = "9"; }
            else
            { textBox1.Text += "9"; }
        }

        private void add3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = "3"; }
            else
            { textBox1.Text += "3"; }
        }
        private void add1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = "1"; }
            else
            { textBox1.Text += "1"; }
        }

        private void add2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = "2"; }
            else
            { textBox1.Text += "2"; }
        }
        private void add4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = "4"; }
            else
            { textBox1.Text += "4"; }
        }

        private void add5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = "5"; }
            else
            { textBox1.Text += "5"; }
        }

        private void add6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = "6"; }
            else
            { textBox1.Text += "6"; }
        }

        private void add7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = "7"; }
            else
            { textBox1.Text += "7"; }
        }

        private void add8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = "8"; }
            else
            { textBox1.Text += "8"; }
        }

        private void add0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            else
            { textBox1.Text += "0"; }
        }

        private void suboper_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";

        }

        private void multiplyoper_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";

        }

        private void divisionoper_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void squareoper_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "square";
           

        }

        private void comma_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            { textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1); }


        }

        private void squarerootoper_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "square root";
            
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = "3"; }
            else
            { textBox1.Text += "3"; }
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (textBox1.Text.StartsWith("0"))
                { }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                    count = 1;
                }
            }
            else
            {
                if (textBox1.Text.StartsWith("0"))
                {  }
                else
                { 
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
                count = 0;
            }

        }
    }
}
