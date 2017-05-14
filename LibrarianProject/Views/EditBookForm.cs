using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarianProject
{
    public partial class EditBookForm : Form
    {
        User currentUser;
        List<Book> bookList = new List<Book>();
        public EditBookForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            lbBooks.DataSource = BooksBinder.getBooksFromDatabase();
        }



        private void bBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(currentUser);
            this.Hide();
            adminForm.Show();
        }

        private void bEditBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbBookTitle.Text) && !(lbBooks.SelectedItem == null))
            {
                Book myBook = (Book)lbBooks.SelectedItem;
                LibraryConnector.editBookTitle(tbBookTitle.Text, myBook.title);
                bookList = LibraryConnector.getBooks();
                ArrayList updatedBookList = new ArrayList(this.bookList);
                lbBooks.DataSource = updatedBookList;
            }

        }

        private void bEditAuthor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbBookAuthor.Text) && !(lbBooks.SelectedItem==null))
            {
                Book myBook = (Book)lbBooks.SelectedItem;
                LibraryConnector.editBookAuthor(tbBookAuthor.Text, myBook.author);
                bookList = LibraryConnector.getBooks();
                ArrayList updatedBookList = new ArrayList(this.bookList);
                lbBooks.DataSource = updatedBookList;
            }
        }

        private void bBookISBN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbBookISBN.Text) && !(lbBooks.SelectedItem == null))
            {
                Book myBook = (Book)lbBooks.SelectedItem;
                LibraryConnector.editBookISBN(tbBookISBN.Text, myBook.ISBN);
                bookList = LibraryConnector.getBooks();
                ArrayList updatedBookList = new ArrayList(this.bookList);
                lbBooks.DataSource = updatedBookList;
                
            }
        }

        public static implicit operator EditBookForm(RegisterUserForm v)
        {
            throw new NotImplementedException();
        }
    }
}
