using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//add book to database. probably should also add ability to edit a book and add a listview with all books already there

namespace LibrarinProject
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
            LibraryConnector addBookConnection = new LibrarinProject.LibraryConnector();
            if ((!string.IsNullOrWhiteSpace(tISBN.Text) || string.IsNullOrWhiteSpace(tAuthor.Text) || string.IsNullOrWhiteSpace(tTitle.Text)))
            {
                Boolean bookAdded = addBookConnection.addBook(tTitle.Text, tISBN.Text, tAuthor.Text);
                if (bookAdded)
                {
                    lAddBookResponse.Text = "Book added correctly!";
                    tTitle.Clear();
                    tAuthor.Clear();
                    tISBN.Clear();

                }
                else
                {
                    lAddBookResponse.Text = "Book already exists.";
                }
            }
            else{
                lAddBookResponse.Text = "Make sure you put an entry into every category!";
            }

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new LibrarinProject.AdminForm(currentUser);
            adminForm.Show();
            this.Hide();
        }
    }
}
