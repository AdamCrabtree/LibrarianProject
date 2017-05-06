namespace LibrarianProject
{
    partial class AdminForm
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
            this.bAddBook = new System.Windows.Forms.Button();
            this.bAddUser = new System.Windows.Forms.Button();
            this.bRequestBook = new System.Windows.Forms.Button();
            this.lWelcome = new System.Windows.Forms.Label();
            this.bLogout = new System.Windows.Forms.Button();
            this.bAccount = new System.Windows.Forms.Button();
            this.bEditBook = new System.Windows.Forms.Button();
            this.bReturnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAddBook
            // 
            this.bAddBook.Location = new System.Drawing.Point(91, 90);
            this.bAddBook.Name = "bAddBook";
            this.bAddBook.Size = new System.Drawing.Size(93, 22);
            this.bAddBook.TabIndex = 1;
            this.bAddBook.Text = "Add Book";
            this.bAddBook.UseVisualStyleBackColor = true;
            this.bAddBook.Click += new System.EventHandler(this.bAddBook_Click);
            // 
            // bAddUser
            // 
            this.bAddUser.Location = new System.Drawing.Point(91, 118);
            this.bAddUser.Name = "bAddUser";
            this.bAddUser.Size = new System.Drawing.Size(93, 22);
            this.bAddUser.TabIndex = 2;
            this.bAddUser.Text = "Add User";
            this.bAddUser.UseVisualStyleBackColor = true;
            this.bAddUser.Click += new System.EventHandler(this.bAddUser_Click);
            // 
            // bRequestBook
            // 
            this.bRequestBook.Location = new System.Drawing.Point(91, 61);
            this.bRequestBook.Name = "bRequestBook";
            this.bRequestBook.Size = new System.Drawing.Size(93, 23);
            this.bRequestBook.TabIndex = 0;
            this.bRequestBook.Text = "Request Book";
            this.bRequestBook.UseVisualStyleBackColor = true;
            this.bRequestBook.Click += new System.EventHandler(this.bRequestBook_Click);
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lWelcome.Location = new System.Drawing.Point(109, 22);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(35, 13);
            this.lWelcome.TabIndex = 3;
            this.lWelcome.Text = "label1";
            // 
            // bLogout
            // 
            this.bLogout.Location = new System.Drawing.Point(203, 12);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(69, 23);
            this.bLogout.TabIndex = 3;
            this.bLogout.Text = "Logout";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // bAccount
            // 
            this.bAccount.Location = new System.Drawing.Point(202, 41);
            this.bAccount.Name = "bAccount";
            this.bAccount.Size = new System.Drawing.Size(69, 23);
            this.bAccount.TabIndex = 4;
            this.bAccount.Text = "Account";
            this.bAccount.UseVisualStyleBackColor = true;
            this.bAccount.Click += new System.EventHandler(this.bAccount_Click);
            // 
            // bEditBook
            // 
            this.bEditBook.Location = new System.Drawing.Point(91, 147);
            this.bEditBook.Name = "bEditBook";
            this.bEditBook.Size = new System.Drawing.Size(93, 23);
            this.bEditBook.TabIndex = 5;
            this.bEditBook.Text = "Edit Book";
            this.bEditBook.UseVisualStyleBackColor = true;
            this.bEditBook.Click += new System.EventHandler(this.bEditBook_Click);
            // 
            // bReturnBook
            // 
            this.bReturnBook.Location = new System.Drawing.Point(91, 176);
            this.bReturnBook.Name = "bReturnBook";
            this.bReturnBook.Size = new System.Drawing.Size(93, 23);
            this.bReturnBook.TabIndex = 6;
            this.bReturnBook.Text = "Return Book";
            this.bReturnBook.UseVisualStyleBackColor = true;
            this.bReturnBook.Click += new System.EventHandler(this.bReturnBook_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bReturnBook);
            this.Controls.Add(this.bEditBook);
            this.Controls.Add(this.bAccount);
            this.Controls.Add(this.bLogout);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.bRequestBook);
            this.Controls.Add(this.bAddUser);
            this.Controls.Add(this.bAddBook);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddBook;
        private System.Windows.Forms.Button bAddUser;
        private System.Windows.Forms.Button bRequestBook;
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Button bLogout;
        private System.Windows.Forms.Button bAccount;
        private System.Windows.Forms.Button bEditBook;
        private System.Windows.Forms.Button bReturnBook;
    }
}