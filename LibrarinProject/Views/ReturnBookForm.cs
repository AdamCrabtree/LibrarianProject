using System;
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
    public partial class ReturnBookForm : Form
    {
        User currentUser;
        public ReturnBookForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void bReturnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbISBN.Text))
            {
                LibraryConnector.returnBook(tbISBN.Text);
                lReturnBookStatus.Text = "Book returned!";
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new LibrarianProject.AdminForm(currentUser);
            this.Hide();
            adminForm.Show();
        }
    }
}
