namespace LibrarianProject
{
    partial class ReturnBookForm
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
            this.bReturnBook = new System.Windows.Forms.Button();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.lReturnBookStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bReturnBook
            // 
            this.bReturnBook.Location = new System.Drawing.Point(86, 132);
            this.bReturnBook.Name = "bReturnBook";
            this.bReturnBook.Size = new System.Drawing.Size(75, 23);
            this.bReturnBook.TabIndex = 0;
            this.bReturnBook.Text = "Return Book";
            this.bReturnBook.UseVisualStyleBackColor = true;
            this.bReturnBook.Click += new System.EventHandler(this.bReturnBook_Click);
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(75, 88);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(100, 20);
            this.tbISBN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN";
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(197, 12);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 3;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lReturnBookStatus
            // 
            this.lReturnBookStatus.AutoSize = true;
            this.lReturnBookStatus.Location = new System.Drawing.Point(86, 183);
            this.lReturnBookStatus.Name = "lReturnBookStatus";
            this.lReturnBookStatus.Size = new System.Drawing.Size(0, 13);
            this.lReturnBookStatus.TabIndex = 4;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lReturnBookStatus);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.bReturnBook);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bReturnBook;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label lReturnBookStatus;
    }
}