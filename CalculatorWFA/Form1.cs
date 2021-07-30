using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex r = new Regex("[^0-9]");
            if(!(r.IsMatch(textBox1.Text))  && !(r.IsMatch(textBox2.Text)))
            {
                int result;
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                if (radioButton1.Checked)
                {
                    result = num1 + num2;
                    MessageBox.Show("Addition of two numbers is "+result.ToString());
                }
                if (radioButton2.Checked)
                {
                    result = num1 - num2;
                    MessageBox.Show("Subtraction of two numbers is " + result.ToString());
                }

                if (radioButton3.Checked)
                {
                    result = num1 * num2;
                    MessageBox.Show("Multiplication of two numbers is " + result.ToString());
                }
                if (radioButton4.Checked)
                {
                    try
                    {
                        result = num1 / num2;
                        MessageBox.Show("Division of two numbers is " + result.ToString());
                    }
                    catch(DivideByZeroException)
                    {
                        MessageBox.Show("Divide By Zero Exception");
                    }
                   
                }
            }
           
           

        else
            {
                MessageBox.Show("Enter correct format for inputs");
            }
          

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
