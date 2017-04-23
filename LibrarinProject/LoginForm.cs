using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//launch form everything starts with this and you try to log in
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
                if (currentUser.success.Equals("true")) //request goes through correctly and assigns to currentUser
                {
                    AdminForm adminForm = new LibrarinProject.AdminForm(currentUser);//the admin form takes in the current user to keep track of who's logged in
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    tFailedLogin.Text = "Login Failed"; //if something not related to the serialization went wrong. This shouldn't happen. 
                }
            }
            catch
            {
                tFailedLogin.Text = "Login Failed"; //json object didn't serialize correctly so current user is null so the try will fail and will fall down to here
            }           
        }
    }
}
