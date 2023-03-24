using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signUp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox1.Text;
           string role= CredentialDL.SignIn(username, password, CredentialDL.signUpdata);
            if (role == RoleTextBox.Text){
                MessageLabel.Text = "Congratulations, You have successfully loged In.";
                MessageLabel.BackColor = Color.GreenYellow;
                MessageLabel.Visible = true;

            }
            else
            {
                MessageLabel.Text = "You are failed in login.";
                MessageLabel.BackColor = Color.Red;
                MessageLabel.Visible = true;
            }

            
        }

        private void BackToSignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();

        }

        private void MessageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
