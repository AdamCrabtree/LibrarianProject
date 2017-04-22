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
    public partial class AdminForm : Form
    {
        User currentUser;
        public AdminForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            if (!currentUser.role.Equals("3"))
            {
                bAddUser.Hide();
            }
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            RegisterUserForm register = new RegisterUserForm();
            register.Show();
            this.Hide();
        }

        private void bAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
            this.Hide();
        }

        private void bRequestBook_Click(object sender, EventArgs e)
        {
            BookRequestForm bookRequestForm = new BookRequestForm();
            bookRequestForm.Show();
            this.Hide();
        }
    }
}
