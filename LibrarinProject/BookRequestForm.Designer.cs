namespace LibrarinProject
{
    partial class BookRequestForm
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
            this.lbBookList = new System.Windows.Forms.ListBox();
            this.bRequestBook = new System.Windows.Forms.Button();
            this.lbookRequestStatus = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBookList
            // 
            this.lbBookList.FormattingEnabled = true;
            this.lbBookList.Location = new System.Drawing.Point(3, 33);
            this.lbBookList.Name = "lbBookList";
            this.lbBookList.Size = new System.Drawing.Size(409, 199);
            this.lbBookList.TabIndex = 3;
            // 
            // bRequestBook
            // 
            this.bRequestBook.Location = new System.Drawing.Point(165, 238);
            this.bRequestBook.Name = "bRequestBook";
            this.bRequestBook.Size = new System.Drawing.Size(75, 23);
            this.bRequestBook.TabIndex = 1;
            this.bRequestBook.Text = "Request Book";
            this.bRequestBook.UseVisualStyleBackColor = true;
            this.bRequestBook.Click += new System.EventHandler(this.bRequestBook_Click);
            // 
            // lbookRequestStatus
            // 
            this.lbookRequestStatus.AutoSize = true;
            this.lbookRequestStatus.Location = new System.Drawing.Point(165, 14);
            this.lbookRequestStatus.Name = "lbookRequestStatus";
            this.lbookRequestStatus.Size = new System.Drawing.Size(0, 13);
            this.lbookRequestStatus.TabIndex = 5;
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(3, 3);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 2;
            this.bBack.Text = "Go Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // BookRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 273);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.lbookRequestStatus);
            this.Controls.Add(this.bRequestBook);
            this.Controls.Add(this.lbBookList);
            this.Name = "BookRequestForm";
            this.Text = "BookRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbBookList;
        private System.Windows.Forms.Button bRequestBook;
        private System.Windows.Forms.Label lbookRequestStatus;
        private System.Windows.Forms.Button bBack;
    }
}