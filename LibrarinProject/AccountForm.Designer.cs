namespace LibrarinProject
{
    partial class AccountForm
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
            this.lWelcome = new System.Windows.Forms.Label();
            this.bChangePassword = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.lUsername = new System.Windows.Forms.Label();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Location = new System.Drawing.Point(111, 22);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(45, 13);
            this.lWelcome.TabIndex = 2;
            this.lWelcome.Text = "No Text";
            // 
            // bChangePassword
            // 
            this.bChangePassword.Location = new System.Drawing.Point(82, 92);
            this.bChangePassword.Name = "bChangePassword";
            this.bChangePassword.Size = new System.Drawing.Size(115, 23);
            this.bChangePassword.TabIndex = 3;
            this.bChangePassword.Text = "Change Password";
            this.bChangePassword.UseVisualStyleBackColor = true;
            this.bChangePassword.Click += new System.EventHandler(this.bChangePassword_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(197, 12);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 4;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(111, 46);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(45, 13);
            this.lUsername.TabIndex = 5;
            this.lUsername.Text = "No Text";
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(1, 154);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(282, 108);
            this.lbBooks.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Books you currently have checked out";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bChangePassword);
            this.Controls.Add(this.lWelcome);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Button bChangePassword;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Label label1;
    }
}