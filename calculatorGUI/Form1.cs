using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public char operation = ' ';
        public double textBox1 = 0F;
        public double getNumber()
        {
            string number ="";
            int index = 0;
            for(int i=0; i<textBox.Text.Length; i++)
            {
                if(textBox.Text[i] >= 0 && textBox.Text[i] <= 9)
                {
                    continue;
                }
                else
                {
                    index = i;
                    break;
                }
            }
            for (int i = index + 2; i < textBox.Text.Length; i++)
            {
                number = number + textBox.Text[i];
            }
            return double.Parse(number);
            }
        private void zerobtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 0;
        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 1 ;
            
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 2;
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 3;
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 4;
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 5;
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 6;
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 7;
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 8;
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 9;
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
             textBox1 = float.Parse(textBox.Text);
            textBox.Text = textBox.Text + "+";
            operation = '+';
        }

        private void negativebtn_Click(object sender, EventArgs e)
        {
             textBox1 = float.Parse(textBox.Text);
            textBox.Text = textBox.Text + "-";
            operation = '-';
        }

        private void multiplybtn_Click(object sender, EventArgs e)
        {
            textBox1 = float.Parse(textBox.Text);
            textBox.Text = textBox.Text + "*";
            operation = '*';
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
             textBox1 = float.Parse(textBox.Text);
            textBox.Text = textBox.Text + "/";
            operation = '/';
        }

        private void squarebtn_Click(object sender, EventArgs e)
        {
             textBox1 = float.Parse(textBox.Text);
            textBox.Text = textBox.Text + "²";
            operation = '²';
        }

        private void cubebtn_Click(object sender, EventArgs e)
        {
             textBox1 = float.Parse(textBox.Text);
            textBox.Text = textBox.Text + "³";
            operation = '³';
        }

        private void sinbtn_Click(object sender, EventArgs e)
        {
             textBox1 = float.Parse(textBox.Text);
            textBox.Text = "sin" + textBox.Text;
        }

        private void cosbtn_Click(object sender, EventArgs e)
        {
             textBox1 = float.Parse(textBox.Text);
            textBox.Text =  "cos"  + textBox.Text ;
        }

        private void tanbtn_Click(object sender, EventArgs e)
        {
             textBox1 = float.Parse(textBox.Text);
            textBox.Text =  "tan" + textBox.Text;
        }
        
        private void equalbtn_Click(object sender, EventArgs e)
        {
            
            if (operation == '+')
            {
                double textBox2 = getNumber();
                double result = textBox1 + textBox2;
                textBox.Text = result.ToString();
            }
           else if (operation == '-')
            {
                double textBox2 = getNumber();
                if (textBox2 >= 0)
                {
                    double result = textBox1 - textBox2;
                    textBox.Text = result.ToString();
                }
                else
                {
                    double result = textBox2 + textBox1;
                    textBox.Text = result.ToString();
                }
                
            }
           else if (operation == '*')
            {
                double textBox2 = getNumber();
                double result = textBox1 * textBox2;
                textBox.Text = result.ToString();
            }
           else if (operation == '/')
            {
                double textBox2 = getNumber();
                double result = textBox1 / textBox2;
                textBox.Text = result.ToString();
            }
           else if (operation == '²')
            {
                double result = Math.Pow(textBox1 , 2); 
                textBox.Text = result.ToString();
            }
           else if (operation == '³')
            {
                double result = Math.Pow(textBox1, 3);
                textBox.Text = result.ToString();
            }
          

        }

        private void cbtn_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CEbtn_Click(object sender, EventArgs e)
        {
            textBox.Text = " ";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
