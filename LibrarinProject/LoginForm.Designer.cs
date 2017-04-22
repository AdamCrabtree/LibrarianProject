using System;

namespace LibrarinProject
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.bUsername = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bLogin = new System.Windows.Forms.Button();
            this.bPassword = new System.Windows.Forms.TextBox();
            this.tFailedLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bUsername
            // 
            this.bUsername.AccessibleName = "Username";
            this.bUsername.Location = new System.Drawing.Point(74, 47);
            this.bUsername.Name = "bUsername";
            this.bUsername.Size = new System.Drawing.Size(100, 20);
            this.bUsername.TabIndex = 0;
            this.bUsername.Tag = "bUsername";
            // 
            // bLogin
            // 
            this.bLogin.AccessibleName = "Login";
            this.bLogin.Location = new System.Drawing.Point(86, 141);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 1;
            this.bLogin.Tag = "bLogin";
            this.bLogin.Text = "Login";
            this.bLogin.UseCompatibleTextRendering = true;
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click_1);
            // 
            // bPassword
            // 
            this.bPassword.AccessibleName = "bPassword";
            this.bPassword.Location = new System.Drawing.Point(74, 86);
            this.bPassword.Name = "bPassword";
            this.bPassword.Size = new System.Drawing.Size(100, 20);
            this.bPassword.TabIndex = 2;
            this.bPassword.Tag = "bPassword";
            // 
            // tFailedLogin
            // 
            this.tFailedLogin.AutoSize = true;
            this.tFailedLogin.Location = new System.Drawing.Point(83, 186);
            this.tFailedLogin.Name = "tFailedLogin";
            this.tFailedLogin.Size = new System.Drawing.Size(0, 13);
            this.tFailedLogin.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tFailedLogin);
            this.Controls.Add(this.bPassword);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.bUsername);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bUsername;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox bPassword;
        private System.Windows.Forms.Label tFailedLogin;
    }
}

