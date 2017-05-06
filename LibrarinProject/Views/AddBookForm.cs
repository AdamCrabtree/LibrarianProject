using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Add book to database form. Create an AddBookBinder that uses String addBook(ISBN, Title, Author) to actually add the book. Set lAddBookResponse to the outcome 
/// of attempting to add the book
/// </summary>
namespace LibrarianProject
{
    public partial class AddBookForm : Form
    {
        User currentUser;
        public AddBookForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void bAddBook_Click(object sender, EventArgs e)
        {
            string outcome = AddBookBinder.addBook(tbISBN.Text, tbTitle.Text, tbAuthor.Text);
            lAddBookResponse.Text = outcome;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new LibrarianProject.AdminForm(currentUser);
            adminForm.Show();
            this.Hide();
        }
    }
}
