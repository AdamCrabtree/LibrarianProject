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

namespace LibrarinProject
{
    public partial class AccountForm : Form
    {
        private User currentUser;
        List<Book> bookList = new List<Book>();
        public AccountForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            requestCheckedOutBooks();
            lWelcome.Text = "Welcome";
            lUsername.Text = currentUser.username;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new LibrarinProject.AdminForm(currentUser);
            adminForm.Show();
            this.Hide();
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            PasswordChangeForm pwChangeForm = new PasswordChangeForm(currentUser);
            pwChangeForm.Show();
            this.Hide();
        }
        private void requestCheckedOutBooks()
        {
            LibraryConnector checkedOutBooksConnector = new LibrarinProject.LibraryConnector();
            bookList = checkedOutBooksConnector.getCheckedOutBooks(currentUser.user_id);
            ArrayList bookArrayList = new ArrayList(bookList);
            lbBooks.DataSource = bookArrayList;
        }
    }
}
