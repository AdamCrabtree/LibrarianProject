using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//add book to database. probably should also add ability to edit a book and add a listview with all books already there

namespace LibrarinProject
{
    public partial class AddBookForm : Form
    {
        User currentUser;
        public AddBookForm(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void bAddBook_Click(object sender, EventArgs e)
        {
            LibraryConnector addBookConnection = new LibrarinProject.LibraryConnector();
            if ((!string.IsNullOrWhiteSpace(tISBN.Text) && !string.IsNullOrWhiteSpace(tAuthor.Text) && !string.IsNullOrWhiteSpace(tTitle.Text)))
            {
                if (ISBNCheck(tISBN.Text))
                {
                    Boolean bookAdded = addBookConnection.addBook(tTitle.Text, tISBN.Text, tAuthor.Text);
                    if (bookAdded)
                    {
                        lAddBookResponse.Text = "Book added correctly!";
                        tTitle.Clear();
                        tAuthor.Clear();
                        tISBN.Clear();

                    }
                    else
                    {
                        lAddBookResponse.Text = "Book already exists.";
                    }
                }
               else
                {
                    lAddBookResponse.Text = "ISBN is incorrect!";
                }
   
            }
            else{
                lAddBookResponse.Text = "Make sure you put an entry into every category!";
            }

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new LibrarinProject.AdminForm(currentUser);
            adminForm.Show();
            this.Hide();
        }
        private bool ISBNCheck(String isbn)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(isbn))
            {
                if (isbn.Contains("-")) isbn = isbn.Replace("-", "");

                switch (isbn.Length)
                {
                    case 10: result = IsValidIsbn10(isbn); break;
                    case 13: result = IsValidIsbn13(isbn); break;
                }
            }

            return result;
        }
        private static bool IsValidIsbn10(string isbn10)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(isbn10))
            {
                if (isbn10.Contains("-")) isbn10 = isbn10.Replace("-", "");

                long j;

                if (isbn10.Length != 10 || !long.TryParse(isbn10.Substring(0, isbn10.Length - 1), out j))
                    return false;

                char lastChar = isbn10[isbn10.Length - 1];

                int sum = 0;
                for (int i = 0; i < 9; i++)
                    sum += int.Parse(isbn10[i].ToString()) * (i + 1);

                int remainder = sum % 11;

                if (lastChar == 'X')
                {
                    result = (remainder == 10);
                }

                else if (int.TryParse(lastChar.ToString(), out sum))
                {
                    result = (remainder == int.Parse(lastChar.ToString()));
                }
            }

            return result;
        }

        private static bool IsValidIsbn13(string isbn13)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(isbn13))
            {
                if (isbn13.Contains("-")) isbn13 = isbn13.Replace("-", "");

                // If the length is not 13 or if it contains any non numeric chars, return false
                long temp;
                if (isbn13.Length != 13 || !long.TryParse(isbn13, out temp)) return false;

                // Comment Source: Wikipedia
                // The calculation of an ISBN-13 check digit begins with the first
                // 12 digits of the thirteen-digit ISBN (thus excluding the check digit itself).
                // Each digit, from left to right, is alternately multiplied by 1 or 3,
                // then those products are summed modulo 10 to give a value ranging from 0 to 9.
                // Subtracted from 10, that leaves a result from 1 to 10. A zero (0) replaces a
                // ten (10), so, in all cases, a single check digit results.
                int sum = 0;
                for (int i = 0; i < 12; i++)
                {
                    sum += int.Parse(isbn13[i].ToString()) * (i % 2 == 1 ? 3 : 1);
                }

                int remainder = sum % 10;
                int checkDigit = 10 - remainder;
                if (checkDigit == 10) checkDigit = 0;

                result = (checkDigit == int.Parse(isbn13[12].ToString()));
            }

            return result;
        }
    }

}
}
