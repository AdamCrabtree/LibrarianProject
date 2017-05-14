using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;

//for requesting books uses list view box and a request button that gets the selected book checked out if its status is in

//find a way to make it able to display better


namespace LibrarianProject
{
    public partial class BookRequestForm : Form
    {
        User currentUser;
        List<Book> bookList = new List<Book>();
        public BookRequestForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            bindBookList();
        }
        private void bindBookList()
        {
            lbBookList.DataSource = BooksBinder.getBooksFromDatabase();
        }

        private void bRequestBook_Click(object sender, EventArgs e)
        {
            Book myBook = (Book) lbBookList.SelectedItem;
            Tuple<ArrayList, String> requestTuple = BooksBinder.checkOutBook(myBook, currentUser, bookList);
            lbBookList.DataSource = requestTuple.Item1;
            lbookRequestStatus.Text = requestTuple.Item2;
            
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new LibrarianProject.AdminForm(currentUser);
            adminForm.Show();
            this.Hide();
        }
    }
}
