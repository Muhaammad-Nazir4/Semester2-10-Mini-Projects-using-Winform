
namespace signUp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UsernameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PasswordTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.RoleTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.lblnavigation = new System.Windows.Forms.LinkLabel();
            this.ExistingMessageLabel = new System.Windows.Forms.Label();
            this.EyeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(283, 204);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(325, 20);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.UsernameTextBox_MaskInputRejected);
            // 
            // PasswordTextBox1
            // 
            this.PasswordTextBox1.Location = new System.Drawing.Point(283, 259);
            this.PasswordTextBox1.Name = "PasswordTextBox1";
            this.PasswordTextBox1.PasswordChar = '*';
            this.PasswordTextBox1.Size = new System.Drawing.Size(325, 20);
            this.PasswordTextBox1.TabIndex = 2;
            this.PasswordTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PasswordTextBox1_MaskInputRejected);
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Location = new System.Drawing.Point(283, 308);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(325, 20);
            this.RoleTextBox.TabIndex = 3;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsernameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(157, 204);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(108, 27);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username";
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignUpLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.Location = new System.Drawing.Point(373, 134);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(139, 26);
            this.SignUpLabel.TabIndex = 7;
            this.SignUpLabel.Text = "signUp Page";
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Gray;
            this.SignUpButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(474, 370);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(134, 39);
            this.SignUpButton.TabIndex = 11;
            this.SignUpButton.Text = "SignUp";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ApplicationLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationLabel.Location = new System.Drawing.Point(256, 58);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(382, 37);
            this.ApplicationLabel.TabIndex = 12;
            this.ApplicationLabel.Text = "SignUp SignIn Applications ";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(157, 252);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 27);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "Password";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RoleLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(180, 308);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(57, 27);
            this.RoleLabel.TabIndex = 14;
            this.RoleLabel.Text = "Role";
            // 
            // lblnavigation
            // 
            this.lblnavigation.AutoSize = true;
            this.lblnavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnavigation.Location = new System.Drawing.Point(157, 376);
            this.lblnavigation.Name = "lblnavigation";
            this.lblnavigation.Size = new System.Drawing.Size(188, 25);
            this.lblnavigation.TabIndex = 15;
            this.lblnavigation.TabStop = true;
            this.lblnavigation.Text = "Go to login Page";
            this.lblnavigation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblnavigation_LinkClicked);
            // 
            // ExistingMessageLabel
            // 
            this.ExistingMessageLabel.AutoSize = true;
            this.ExistingMessageLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ExistingMessageLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingMessageLabel.Location = new System.Drawing.Point(238, 434);
            this.ExistingMessageLabel.Name = "ExistingMessageLabel";
            this.ExistingMessageLabel.Size = new System.Drawing.Size(314, 37);
            this.ExistingMessageLabel.TabIndex = 16;
            this.ExistingMessageLabel.Text = "ExistingMessageLabel ";
            this.ExistingMessageLabel.Visible = false;
            this.ExistingMessageLabel.Click += new System.EventHandler(this.ExistingMessageLabel_Click);
            // 
            // EyeButton
            // 
            this.EyeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EyeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EyeButton.BackgroundImage")));
            this.EyeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EyeButton.Location = new System.Drawing.Point(584, 258);
            this.EyeButton.Name = "EyeButton";
            this.EyeButton.Size = new System.Drawing.Size(24, 21);
            this.EyeButton.TabIndex = 17;
            this.EyeButton.UseVisualStyleBackColor = false;
            this.EyeButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 516);
            this.Controls.Add(this.EyeButton);
            this.Controls.Add(this.ExistingMessageLabel);
            this.Controls.Add(this.lblnavigation);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ApplicationLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.PasswordTextBox1);
            this.Controls.Add(this.UsernameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox UsernameTextBox;
        private System.Windows.Forms.MaskedTextBox PasswordTextBox1;
        private System.Windows.Forms.MaskedTextBox RoleTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label ApplicationLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.LinkLabel lblnavigation;
        private System.Windows.Forms.Label ExistingMessageLabel;
        private System.Windows.Forms.Button EyeButton;
    }
}

