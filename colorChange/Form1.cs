using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
                    
             if(TextBox.BackColor == Color.Red)
             {
                 TextBox.BackColor = Color.Green;                      
            }
            else if(TextBox.BackColor == Color.Green)
            {
                TextBox.BackColor = Color.Blue;
            }
             else if(TextBox.BackColor == Color.Blue)
            {
                TextBox.BackColor = Color.Red;
            }


        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {

            if (TextBox.BackColor == Color.Blue)
            {
                TextBox.BackColor = Color.Green;
            }
            else if (TextBox.BackColor == Color.Green)
            {
                TextBox.BackColor = Color.Red;
            }
            else if (TextBox.BackColor == Color.Red)
            {
                TextBox.BackColor = Color.Blue;
            }
        }
    }
}
