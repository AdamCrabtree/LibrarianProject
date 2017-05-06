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
/// Admin form for navigation to requesting a book, adding a book, adding a user, editing password and editing a book, this 
/// this is basically a holdover form with no internal logic other than showing and navigating to different UI elements
/// </summary>

namespace LibrarianProject
{
    public partial class AdminForm : Form
    {
        User currentUser;
        public AdminForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            if (!currentUser.role.Equals("3")) //if user is not root
            {
                bAddUser.Hide();
            }
            if (!currentUser.role.Equals("2") && !currentUser.role.Equals("3")) //if user is not admin nor root
            {
                bAddBook.Hide();
                bEditBook.Hide();
                bReturnBook.Hide();
            }
            lWelcome.Text = "Welcome " + currentUser.username; 
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            RegisterUserForm register = new RegisterUserForm(currentUser);
            register.Show();
            this.Hide();
        }

        private void bAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(currentUser);
            addBookForm.Show();
            this.Hide();
        }

        private void bRequestBook_Click(object sender, EventArgs e)
        {
            BookRequestForm bookRequestForm = new BookRequestForm(currentUser);
            bookRequestForm.Show();
            this.Hide();
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LibrarianProject.LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void bAccount_Click(object sender, EventArgs e)
        {
            lWelcome.Text = "welcome" + currentUser.name;
            AccountForm accountForm = new AccountForm(this.currentUser);
            accountForm.Show();
            this.Hide();
        }

        private void bEditBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditBookForm editBookForm = new EditBookForm(currentUser);
            editBookForm.Show();
        }

        private void bReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnBookForm = new ReturnBookForm(currentUser);
            this.Hide();
            returnBookForm.Show();
        }
    }
}
