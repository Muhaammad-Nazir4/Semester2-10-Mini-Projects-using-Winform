using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoping_cart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double shirtsTotal , pantsTotal , shoesTotal , perfumeTotal;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void shirtBtn_Click(object sender, EventArgs e)
        {
            shirtsTextBox.Text = " ";
        }

        private void ShoesBtn_Click(object sender, EventArgs e)
        {
            shoesTextBox.Text = " ";
        }

        private void pantsBtn_Click(object sender, EventArgs e)
        {
            pantsTextBox.Text = " ";
        }

        private void perfumeBtn_Click(object sender, EventArgs e)
        {
            perfumeTextBox.Text = " ";
        }

        private void shirtsTextBox_TextChanged(object sender, EventArgs e)
        {
            Decimal a;

            bool isAValid = Decimal.TryParse(shirtsTextBox.Text, out a);

            if (isAValid)
            {
                shirtsTotal = 9.95 * int.Parse(shirtsTextBox.Text);
                totalShirtsLabel.Text = "$" +  (shirtsTotal).ToString() ;
            }

            else
                totalShirtsLabel.Text = "Invalid input";
           
        }

        private void shoesTextBox_TextChanged(object sender, EventArgs e)
        {
            Decimal a;

            bool isAValid = Decimal.TryParse(shoesTextBox.Text, out a);

            if (isAValid)
            {
                shoesTotal = 19.95 * int.Parse(shoesTextBox.Text);
                totalShoesLabel.Text = "$" +  (shoesTotal).ToString();

            }

            else
                totalShoesLabel.Text = "Invalid input";
        }

        private void pantsTextBox_TextChanged(object sender, EventArgs e)
        {
            Decimal a;

            bool isAValid = Decimal.TryParse(pantsTextBox.Text, out a);

            if (isAValid)
            {
                pantsTotal = 14.95 * int.Parse(pantsTextBox.Text);
                totalPantsLabel.Text = "$" + (pantsTotal).ToString() ;
            }

            else
                totalPantsLabel.Text = "Invalid input";
        }

        private void perfumeTextBox_TextChanged(object sender, EventArgs e)
        {
            Decimal a;

            bool isAValid = Decimal.TryParse(perfumeTextBox.Text, out a);

            if (isAValid)
            {
                perfumeTotal = 12.5 * int.Parse(perfumeTextBox.Text);
                totalPerfumeLabel.Text = "$" +  (perfumeTotal).ToString() ;
            }

            else
                totalPerfumeLabel.Text = "Invalid input";
        }

        private void totalPerfumeLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                shirtsTextBox.Visible = true;
                shirtsTextBox.Focus();
                priceLabel1.Visible = true;
                totalShirtsLabel.Visible = true;
                shirtBtn.Visible = true;
            }
            else
            {
                shirtsTextBox.Visible = false;
                priceLabel1.Visible = false;
                totalShirtsLabel.Visible = false;
                shirtBtn.Visible = false;
            }
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {
          
        }

        private void TotalPriceBtn_Click(object sender, EventArgs e)
        {
            double total = shirtsTotal + pantsTotal + shoesTotal + perfumeTotal;
            totalLabel.Text = "$" + total.ToString() ;
            totalLabel.Visible = true;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            shirtsTextBox.Visible = false;
            priceLabel1.Visible = false;
            totalShirtsLabel.Visible = false;
            shirtBtn.Visible = false;
            shirtsTextBox.Text = "0";
            shirtsTotal = 0;
            shoesTextBox.Visible = false;
            priceLabel2.Visible = false;
            totalShoesLabel.Visible = false;
            shoesBtn.Visible = false;
            shoesTextBox.Text = "0";
            shoesTotal = 0;
            pantsTextBox.Visible = false;
            priceLabel3.Visible = false;
            totalPantsLabel.Visible = false;
            pantsBtn.Visible = false;
            pantsTextBox.Text = "0";
            pantsTotal = 0;
            perfumeTextBox.Visible = false;
            priceLabel4.Visible = false;
            totalPerfumeLabel.Visible = false;
            perfumeBtn.Visible = false;
            perfumeTextBox.Text = "0";
            perfumeTotal = 0;
            totalLabel.Text = "0";
            totalLabel.Visible = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                shoesTextBox.Visible = true;
                shoesTextBox.Focus();
                priceLabel2.Visible = true;
                totalShoesLabel.Visible = true;
                shoesBtn.Visible = true;
            }
            else
            {
                shoesTextBox.Visible = false;
                priceLabel2.Visible = false;
                totalShoesLabel.Visible = false;
                shoesBtn.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                pantsTextBox.Visible = true;
                pantsTextBox.Focus();
                priceLabel3.Visible = true;
                totalPantsLabel.Visible = true;
                pantsBtn.Visible = true;
            }
            else
            {
                pantsTextBox.Visible = false;
                priceLabel3.Visible = false;
                totalPantsLabel.Visible = false;
                pantsBtn.Visible = false;
            }
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {              
                perfumeTextBox.Visible = true;
                perfumeTextBox.Focus();
                priceLabel4.Visible = true;
                totalPerfumeLabel.Visible = true;
                perfumeBtn.Visible = true;
            }
            else
            {
                perfumeTextBox.Visible = false;
                priceLabel4.Visible = false;
                totalPerfumeLabel.Visible = false;
                perfumeBtn.Visible = false;
            }
           
        }
    }
}
