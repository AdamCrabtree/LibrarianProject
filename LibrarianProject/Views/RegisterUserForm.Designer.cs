﻿namespace LibrarianProject
{
    partial class RegisterUserForm
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
            this.tName = new System.Windows.Forms.TextBox();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bRegister = new System.Windows.Forms.Button();
            this.cbAdminCheck = new System.Windows.Forms.CheckBox();
            this.lRegisterResult = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(127, 51);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(100, 20);
            this.tName.TabIndex = 0;
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(127, 77);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(100, 20);
            this.tUsername.TabIndex = 1;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(127, 103);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(100, 20);
            this.tPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "password";
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(90, 226);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(99, 23);
            this.bRegister.TabIndex = 5;
            this.bRegister.Text = "Register";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // cbAdminCheck
            // 
            this.cbAdminCheck.AutoSize = true;
            this.cbAdminCheck.Location = new System.Drawing.Point(55, 203);
            this.cbAdminCheck.Name = "cbAdminCheck";
            this.cbAdminCheck.Size = new System.Drawing.Size(172, 17);
            this.cbAdminCheck.TabIndex = 4;
            this.cbAdminCheck.Text = "Please check if admin account";
            this.cbAdminCheck.UseVisualStyleBackColor = true;
            // 
            // lRegisterResult
            // 
            this.lRegisterResult.AutoSize = true;
            this.lRegisterResult.Location = new System.Drawing.Point(87, 211);
            this.lRegisterResult.Name = "lRegisterResult";
            this.lRegisterResult.Size = new System.Drawing.Size(0, 13);
            this.lRegisterResult.TabIndex = 8;
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(-5, -1);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 6;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(127, 129);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Retype Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(127, 155);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.lRegisterResult);
            this.Controls.Add(this.cbAdminCheck);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUsername);
            this.Controls.Add(this.tName);
            this.Name = "RegisterUserForm";
            this.Text = "RegisterUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.CheckBox cbAdminCheck;
        private System.Windows.Forms.Label lRegisterResult;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
    }
}