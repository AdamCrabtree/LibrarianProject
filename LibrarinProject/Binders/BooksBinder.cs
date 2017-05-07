using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarianProject
{
    /// <summary>
    /// Are you trying to do something with books from the database? Well then this class is for you!
    /// GetBooksFromDatabase returns an arraylist of books to use in whatever list view you want
    /// checking out books returns a tuple of a string telling your form what happened and an arraylist of books if it actually worked
    /// add book adds a book to the database after validating the ISBN
    /// All methods use LibraryConnector to connect to the database
    /// </summary>
    static class BooksBinder
    {
        static public ArrayList getBooksFromDatabase()
        {
            List<Book> bookList = LibraryConnector.getBooks(); //open connection with site, get json blob, convert json blob into Book list, return book list into here
            ArrayList bookArrayList = new ArrayList(bookList); //convert to ArrayList becaues the datasource can't be just a regular list
            return bookArrayList;
        }
        static public Tuple<ArrayList, String> checkOutBook(Book myBook, User currentUser, List<Book> bookList)
        {
            if (myBook.status == "in")
            {
                LibraryConnector.requestBook(myBook.ISBN, currentUser.user_id);
                bookList = LibraryConnector.getBooks();
                ArrayList updatedBookList = new ArrayList(bookList);
                return Tuple.Create(updatedBookList, "Book requested successfully!");

            }
            else
            {
                ArrayList updatedBookList = new ArrayList(bookList);
                return Tuple.Create(updatedBookList, "Book already checked out!");
            }
        }
        static public string addBook(string ISBN, string title, string author)
        {
            if (ISBNCheck(ISBN))
            {
                Boolean bookAdded = LibraryConnector.addBook(title, ISBN, author);
                if (bookAdded)
                {
                    return "Book added sucessfully!";
                }
                else
                {
                    return "Book already exists!";
                }
            }
            else
            {
                return "ISBN is not a valid ISBN!";
            }
        }
        static private bool ISBNCheck(String isbn)
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
