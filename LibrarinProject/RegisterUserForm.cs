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
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            LibraryConnector registerConnection = new LibrarinProject.LibraryConnector();
            if (cbAdminCheck.Checked) //register admin
            {
                registerConnection.Register(tUsername.Text, tPassword.Text, "2", tName.Text );
            }
            else // register user
            {
                registerConnection.Register(tUsername.Text, tPassword.Text, "1", tName.Text);

            }
        }
    }
}
