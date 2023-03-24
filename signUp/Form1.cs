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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox1.Text;
            string role = RoleTextBox.Text;
            MyUser data = new MyUser(username , password ,role);
            string r = CredentialDL.SignIn(username, password, CredentialDL.signUpdata);
            if (username == "" || password == "" || role == "")
            {
                ExistingMessageLabel.Text = " Please enter all credentials.";
                ExistingMessageLabel.Visible = true;
                ExistingMessageLabel.BackColor = Color.Red;
            }
            else
            {
                if (r == "NA")
                {
                    CredentialDL.addSignUpIntoList(data);
                    UsernameTextBox.Clear();
                    PasswordTextBox1.Clear();
                    RoleTextBox.Clear();
                    ExistingMessageLabel.Text = " You have SignUp successfully.";
                    ExistingMessageLabel.Visible = true;
                    ExistingMessageLabel.BackColor = Color.Green;
                }
                if (r != "NA")
                {
                    ExistingMessageLabel.Text = " User already Exists.";
                    ExistingMessageLabel.Visible = true;
                    ExistingMessageLabel.BackColor = Color.Red;
                }
            }
           
        }

        private void PasswordTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void lblnavigation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 ob = new Form2();
            ob.Show();
        }

        private void UsernameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ExistingMessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void EyeButton_Click(object sender, EventArgs e)
        {
            if(PasswordTextBox1.PasswordChar == '*')
            {
                EyeButton.BringToFront();
                PasswordTextBox1.PasswordChar = '\0';
            }
            else if(PasswordTextBox1.PasswordChar == '\0')
            {
                EyeButton.BringToFront();
                PasswordTextBox1.PasswordChar = '*';
            }  
        }
    }
}
