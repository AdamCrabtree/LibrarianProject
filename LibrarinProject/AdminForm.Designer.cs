namespace LibrarinProject
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
            this.SuspendLayout();
            // 
            // bAddBook
            // 
            this.bAddBook.Location = new System.Drawing.Point(12, 12);
            this.bAddBook.Name = "bAddBook";
            this.bAddBook.Size = new System.Drawing.Size(69, 22);
            this.bAddBook.TabIndex = 0;
            this.bAddBook.Text = "Add Book";
            this.bAddBook.UseVisualStyleBackColor = true;
            this.bAddBook.Click += new System.EventHandler(this.bAddBook_Click);
            // 
            // bAddUser
            // 
            this.bAddUser.Location = new System.Drawing.Point(194, 12);
            this.bAddUser.Name = "bAddUser";
            this.bAddUser.Size = new System.Drawing.Size(69, 22);
            this.bAddUser.TabIndex = 1;
            this.bAddUser.Text = "Add User";
            this.bAddUser.UseVisualStyleBackColor = true;
            this.bAddUser.Click += new System.EventHandler(this.bAddUser_Click);
            // 
            // bRequestBook
            // 
            this.bRequestBook.Location = new System.Drawing.Point(91, 111);
            this.bRequestBook.Name = "bRequestBook";
            this.bRequestBook.Size = new System.Drawing.Size(75, 23);
            this.bRequestBook.TabIndex = 2;
            this.bRequestBook.Text = "Request Book";
            this.bRequestBook.UseVisualStyleBackColor = true;
            this.bRequestBook.Click += new System.EventHandler(this.bRequestBook_Click);
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lWelcome.Location = new System.Drawing.Point(88, 17);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(35, 13);
            this.lWelcome.TabIndex = 3;
            this.lWelcome.Text = "label1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}