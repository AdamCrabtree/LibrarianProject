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
    public partial class PasswordChangeForm : Form
    {
        User currentUser;
        public PasswordChangeForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(tpassword.Text) || string.IsNullOrWhiteSpace(tpassword.Text)) && tpassword.Text.Equals(tpassword2.Text)){
                LibraryConnector pwChangeConnection = new LibraryConnector();
                pwChangeConnection.changePassword(tpassword.Text, currentUser.username);
            }
            else if(string.IsNullOrWhiteSpace(tpassword.Text) || string.IsNullOrWhiteSpace(tpassword.Text)){
                lStatus.Text = "One of your password entries is empty.";
            }
            else if(!(string.IsNullOrWhiteSpace(tpassword.Text) || string.IsNullOrWhiteSpace(tpassword.Text)) && !tpassword.Text.Equals(tpassword2.Text)){
                lStatus.Text = "One of your password entries is incorrect";
            }

            }
        }
    }
