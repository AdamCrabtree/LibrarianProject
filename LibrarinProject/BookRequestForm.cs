using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace LibrarinProject
{
    public partial class BookRequestForm : Form
    {
        public BookRequestForm()
        {
            InitializeComponent();
            requestBooks();
        }
        private void requestBooks()
        {
            List<Book> bookList = new List<Book>();
            LibraryConnector myConnector = new LibraryConnector();
            bookList = myConnector.getBooks();
            ArrayList bookArrayList = new ArrayList(bookList);
            lbBookList.DataSource = bookList;
            Console.Write("for debugging");
        }

        private void bRequestBook_Click(object sender, EventArgs e)
        {
            LibraryConnector myConnector = new LibraryConnector();
            Book myBook = (Book) lbBookList.SelectedItem;
            myConnector.requestBook(myBook.ISBN);
        }
    }
}
