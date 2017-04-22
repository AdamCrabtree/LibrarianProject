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
            this.SuspendLayout();
            // 
            // lbBookList
            // 
            this.lbBookList.FormattingEnabled = true;
            this.lbBookList.Location = new System.Drawing.Point(1, 1);
            this.lbBookList.Name = "lbBookList";
            this.lbBookList.Size = new System.Drawing.Size(409, 199);
            this.lbBookList.TabIndex = 3;
            // 
            // bRequestBook
            // 
            this.bRequestBook.Location = new System.Drawing.Point(161, 217);
            this.bRequestBook.Name = "bRequestBook";
            this.bRequestBook.Size = new System.Drawing.Size(75, 23);
            this.bRequestBook.TabIndex = 4;
            this.bRequestBook.Text = "Requst Book";
            this.bRequestBook.UseVisualStyleBackColor = true;
            this.bRequestBook.Click += new System.EventHandler(this.bRequestBook_Click);
            // 
            // BookRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 273);
            this.Controls.Add(this.bRequestBook);
            this.Controls.Add(this.lbBookList);
            this.Name = "BookRequestForm";
            this.Text = "BookRequestForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbBookList;
        private System.Windows.Forms.Button bRequestBook;
    }
}