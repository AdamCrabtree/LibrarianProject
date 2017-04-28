namespace LibrarinProject
{
    partial class AddBookForm
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
            this.tTitle = new System.Windows.Forms.TextBox();
            this.tAuthor = new System.Windows.Forms.TextBox();
            this.tISBN = new System.Windows.Forms.TextBox();
            this.bAddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lAddBookResponse = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tTitle
            // 
            this.tTitle.Location = new System.Drawing.Point(81, 90);
            this.tTitle.Name = "tTitle";
            this.tTitle.Size = new System.Drawing.Size(100, 20);
            this.tTitle.TabIndex = 0;
            // 
            // tAuthor
            // 
            this.tAuthor.Location = new System.Drawing.Point(81, 116);
            this.tAuthor.Name = "tAuthor";
            this.tAuthor.Size = new System.Drawing.Size(100, 20);
            this.tAuthor.TabIndex = 1;
            // 
            // tISBN
            // 
            this.tISBN.Location = new System.Drawing.Point(81, 142);
            this.tISBN.Name = "tISBN";
            this.tISBN.Size = new System.Drawing.Size(100, 20);
            this.tISBN.TabIndex = 2;
            // 
            // bAddBook
            // 
            this.bAddBook.Location = new System.Drawing.Point(93, 183);
            this.bAddBook.Name = "bAddBook";
            this.bAddBook.Size = new System.Drawing.Size(75, 23);
            this.bAddBook.TabIndex = 3;
            this.bAddBook.Text = "Add Book";
            this.bAddBook.UseVisualStyleBackColor = true;
            this.bAddBook.Click += new System.EventHandler(this.bAddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ISBN";
            // 
            // lAddBookResponse
            // 
            this.lAddBookResponse.AutoSize = true;
            this.lAddBookResponse.Location = new System.Drawing.Point(90, 209);
            this.lAddBookResponse.Name = "lAddBookResponse";
            this.lAddBookResponse.Size = new System.Drawing.Size(0, 13);
            this.lAddBookResponse.TabIndex = 8;
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
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.lAddBookResponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddBook);
            this.Controls.Add(this.tISBN);
            this.Controls.Add(this.tAuthor);
            this.Controls.Add(this.tTitle);
            this.Name = "AddBookForm";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tTitle;
        private System.Windows.Forms.TextBox tAuthor;
        private System.Windows.Forms.TextBox tISBN;
        private System.Windows.Forms.Button bAddBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lAddBookResponse;
        private System.Windows.Forms.Button bBack;
    }
}