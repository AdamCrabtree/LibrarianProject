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
    //register user, 2 is for admin, 1 is for regular user, 3 is for root but there's only one root
    //This launches the admin form after finishing it's duties with the newly registered user
    public partial class RegisterUserForm : Form
    {
        User currentUser;
        public RegisterUserForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();

        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            LibraryConnector registerConnection = new LibrarinProject.LibraryConnector();
            if (cbAdminCheck.Checked) //register admin
            {
                User currentUser = registerConnection.Register(tUsername.Text, tPassword.Text, "2", tName.Text, tbEmail.Text);
                if (currentUser.success.Equals("true"))
                {
                    AdminForm adminForm = new AdminForm(currentUser);
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    lRegisterResult.Text = "Registration failed. A user with this username already exists.";
                }
            }
            else // register user
            {
                try
                {
                    if ((!string.IsNullOrWhiteSpace(tUsername.Text) && !string.IsNullOrWhiteSpace(tPassword.Text) && !string.IsNullOrWhiteSpace(tName.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text)))
                    {
                        if (tPassword.Text.Equals(tbPassword.Text))
                        {
                            User currentUser = registerConnection.Register(tUsername.Text, tPassword.Text, "1", tName.Text, tbEmail.Text);
                            if (currentUser.success.Equals("true"))
                            {
                                AdminForm adminForm = new AdminForm(currentUser);
                                adminForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                lRegisterResult.Text = "Registration failed. A user with this username already exists.";
                            }

                        }
                    else
                        {
                            lRegisterResult.Text = "Please retry. Passwords do not match.";
                        }

                    }
                    else
                    {
                        lRegisterResult.Text = "Registration failed. Make sure all fields are entered.";
                    }
                }

                catch
                {
                    lRegisterResult.Text = "Registration failed. A user with this username already exists.";
                }

            }

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new LibrarinProject.AdminForm(currentUser);
            adminForm.Show();
            this.Hide();
        }
    }
}
