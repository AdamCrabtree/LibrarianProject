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
        Tuple<User, bool> loginTuple;
        LoginModel loginAttempt = new LoginModel();
        public LoginForm()
        {
            InitializeComponent();
        }


        private void bLogin_Click_1(object sender, EventArgs e)
        {
            loginTuple =  loginAttempt.attemptLogin(tbUsername.Text, tbPassword.Text);
            if (loginTuple.Item2 == true)
            {
                AdminForm adminForm = new LibrarinProject.AdminForm(loginTuple.Item1);//the admin form takes in the current user to keep track of who's logged in
                adminForm.Show();
                this.Hide();
            }
            else
            {
                tFailedLogin.Text = "Login failed! Incorrect username or password!";
            }
        }
    }
}
