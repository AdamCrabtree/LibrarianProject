using LibrarianProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Has method of getting books from database to display to the listview in RequestBookForm
/// and
/// CheckOutBook which returns a new updated array list from the database with the book now checked out
/// </summary>
namespace LibrarinProject.View_Models
{
    static class BookRequestBinder
    {
        static public ArrayList getBooksFromDatabase()
        {
            LibraryConnector myConnector = new LibraryConnector();
            List<Book> bookList = myConnector.getBooks(); //open connection with site, get json blob, convert json blob into Book list, return book list into here
            ArrayList bookArrayList = new ArrayList(bookList); //convert to ArrayList becaues the datasource can't be just a regular list
            return bookArrayList;
        }
        static public Tuple<ArrayList, String> checkOutBook(Book myBook, User currentUser, List<Book> bookList)
        {
            if (myBook.status == "in")
            {
                LibraryConnector myConnector = new LibraryConnector();
                myConnector.requestBook(myBook.ISBN, currentUser.user_id);
                bookList = myConnector.getBooks();
                ArrayList updatedBookList = new ArrayList(bookList);
                return Tuple.Create(updatedBookList, "Book requested successfully!");

            }
            else
            {
                ArrayList updatedBookList = new ArrayList(bookList);
                return Tuple.Create(updatedBookList, "Book already checked out!");
            }
        }
    }
}
