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

//for requesting books uses list view box and a request button that gets the selected book checked out if its status is in

//find a way to make it able to display better


namespace LibrarinProject
{
    public partial class BookRequestForm : Form
    {
        User currentUser;
        List<Book> bookList = new List<Book>();
        public BookRequestForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            requestBooks();
        }
        private void requestBooks()
        {
            LibraryConnector myConnector = new LibraryConnector();
            bookList = myConnector.getBooks(); //open connection with site, get json blob, convert json blob into Book list, return book list into here
            ArrayList bookArrayList = new ArrayList(bookList); //convert to ArrayList becaues the datasource can't be just a regular list
            lbBookList.DataSource = bookList;   //set data source items cannot be edited/seleted after data source is set
        }

        private void bRequestBook_Click(object sender, EventArgs e)
        {
            LibraryConnector myConnector = new LibraryConnector();
            Book myBook = (Book) lbBookList.SelectedItem;
            if (myBook.status == "in")
            {
                myConnector.requestBook(myBook.ISBN);
                bookList = myConnector.getBooks(); 
                ArrayList updatedBookList = new ArrayList(this.bookList);
                lbBookList.DataSource = updatedBookList;
                lbookRequestStatus.Text = "Book has been requested!";

            }
            else
            {
                lbookRequestStatus.Text = "Book is already checked out!";
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
