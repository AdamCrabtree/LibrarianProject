using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using LibrarinProject.Views;

/// <summary>
/// Admin form for navigation to requesting a book, adding a book, adding a user, editing password and editing a book, this 
/// this is basically a holdover form with no internal logic other than showing and navigating to different UI elements
/// </summary>

namespace LibrarianProject
{
    public partial class AdminForm : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
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

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Choices adminFormChoices = new Choices();
            adminFormChoices.Add("help", "add user", "edit book", "open account form", "add book", "add user", "logout");
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(adminFormChoices);
            Grammar adminFormGrammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(adminFormGrammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "help":
                    break;
                case "add user":
                    break;
                case "edit book":
                    break;
                case "open account form":
                    break;
                case "add book":
                    break;
                case "logout":
                    break;
            }
        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            HelpForm newHelpForm = new HelpForm();
            newHelpForm.Show();
        }
    }
}
