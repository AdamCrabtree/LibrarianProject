using System;
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
            string outcome = BooksBinder.addBook(tbISBN.Text, tbTitle.Text, tbAuthor.Text);
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
