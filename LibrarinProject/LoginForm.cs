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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void bLogin_Click_1(object sender, EventArgs e)
        {
            LibraryConnector myConnection = new LibraryConnector();
            try
            {
                User currentUser = myConnection.Login(bUsername.Text, bPassword.Text);
                if (currentUser.success.Equals("true") && (currentUser.role.Equals("2") || currentUser.role.Equals("3"))) //request goes through correctly and assigns to currentUser
                {
                    AdminForm newForm = new LibrarinProject.AdminForm(currentUser);
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    tFailedLogin.Text = "Login Failed";
                }
            }
            catch
            {
                tFailedLogin.Text = "Login Failed"; //json object didn't serialize correctly so its null
            }           
        }
    }
}
