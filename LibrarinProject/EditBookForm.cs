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
        LibraryConnector myConnector = new LibraryConnector();
        public EditBookForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            requestBooks();
        }

        private void requestBooks()
        {
            bookList = myConnector.getBooks(); //open connection with site, get json blob, convert json blob into Book list, return book list into here
            ArrayList bookArrayList = new ArrayList(bookList); //convert to ArrayList becaues the datasource can't be just a regular list
            lbBooks.DataSource = bookList;   //set data source items cannot be edited/seleted after data source is set
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
                myConnector.editBookTitle(tbBookTitle.Text, myBook.title);
                bookList = myConnector.getBooks();
                ArrayList updatedBookList = new ArrayList(this.bookList);
                lbBooks.DataSource = updatedBookList;
            }

        }

        private void bEditAuthor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbBookAuthor.Text) && !(lbBooks.SelectedItem==null))
            {
                Book myBook = (Book)lbBooks.SelectedItem;
                myConnector.editBookAuthor(tbBookAuthor.Text, myBook.author);
                bookList = myConnector.getBooks();
                ArrayList updatedBookList = new ArrayList(this.bookList);
                lbBooks.DataSource = updatedBookList;
            }
        }

        private void bBookISBN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbBookISBN.Text) && !(lbBooks.SelectedItem == null))
            {
                Book myBook = (Book)lbBooks.SelectedItem;
                myConnector.editBookISBN(tbBookISBN.Text, myBook.ISBN);
                bookList = myConnector.getBooks();
                ArrayList updatedBookList = new ArrayList(this.bookList);
                lbBooks.DataSource = updatedBookList;
                
            }
        }
    }
}
