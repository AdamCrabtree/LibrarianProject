namespace LibrarianProject
{
    partial class EditBookForm
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
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.bEditBook = new System.Windows.Forms.Button();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.bEditAuthor = new System.Windows.Forms.Button();
            this.tbBookAuthor = new System.Windows.Forms.TextBox();
            this.tbBookISBN = new System.Windows.Forms.TextBox();
            this.bBookISBN = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(12, 31);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(260, 134);
            this.lbBooks.TabIndex = 0;
            // 
            // bEditBook
            // 
            this.bEditBook.Location = new System.Drawing.Point(118, 171);
            this.bEditBook.Name = "bEditBook";
            this.bEditBook.Size = new System.Drawing.Size(95, 23);
            this.bEditBook.TabIndex = 1;
            this.bEditBook.Text = "Edit Book Title";
            this.bEditBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bEditBook.UseVisualStyleBackColor = true;
            this.bEditBook.Click += new System.EventHandler(this.bEditBook_Click);
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Location = new System.Drawing.Point(12, 171);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(100, 20);
            this.tbBookTitle.TabIndex = 2;
            // 
            // bEditAuthor
            // 
            this.bEditAuthor.Location = new System.Drawing.Point(118, 200);
            this.bEditAuthor.Name = "bEditAuthor";
            this.bEditAuthor.Size = new System.Drawing.Size(95, 23);
            this.bEditAuthor.TabIndex = 3;
            this.bEditAuthor.Text = "Edit Book Author";
            this.bEditAuthor.UseVisualStyleBackColor = true;
            this.bEditAuthor.Click += new System.EventHandler(this.bEditAuthor_Click);
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Location = new System.Drawing.Point(12, 202);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbBookAuthor.TabIndex = 4;
            // 
            // tbBookISBN
            // 
            this.tbBookISBN.Location = new System.Drawing.Point(12, 229);
            this.tbBookISBN.Name = "tbBookISBN";
            this.tbBookISBN.Size = new System.Drawing.Size(100, 20);
            this.tbBookISBN.TabIndex = 5;
            // 
            // bBookISBN
            // 
            this.bBookISBN.Location = new System.Drawing.Point(119, 226);
            this.bBookISBN.Name = "bBookISBN";
            this.bBookISBN.Size = new System.Drawing.Size(94, 23);
            this.bBookISBN.TabIndex = 6;
            this.bBookISBN.Text = "Edit Book ISBN";
            this.bBookISBN.UseVisualStyleBackColor = true;
            this.bBookISBN.Click += new System.EventHandler(this.bBookISBN_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(197, 2);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 7;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bBookISBN);
            this.Controls.Add(this.tbBookISBN);
            this.Controls.Add(this.tbBookAuthor);
            this.Controls.Add(this.bEditAuthor);
            this.Controls.Add(this.tbBookTitle);
            this.Controls.Add(this.bEditBook);
            this.Controls.Add(this.lbBooks);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button bEditBook;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.Button bEditAuthor;
        private System.Windows.Forms.TextBox tbBookAuthor;
        private System.Windows.Forms.TextBox tbBookISBN;
        private System.Windows.Forms.Button bBookISBN;
        private System.Windows.Forms.Button bBack;
    }
}