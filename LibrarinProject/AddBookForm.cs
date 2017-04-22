﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarinProject
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void bAddBook_Click(object sender, EventArgs e)
        {
            LibraryConnector addBookConnection = new LibrarinProject.LibraryConnector();
            addBookConnection.addBook(tTitle.Text, tISBN.Text, tAuthor.Text);
        }
    }
}
