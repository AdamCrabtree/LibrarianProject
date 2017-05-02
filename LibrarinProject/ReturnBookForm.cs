using System;
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
                LibraryConnector returnConnection = new LibrarinProject.LibraryConnector();
                returnConnection.returnBook(tbISBN.Text);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new LibrarinProject.AdminForm(currentUser);
            this.Hide();
            adminForm.Show();
        }
    }
}
