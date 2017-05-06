using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// For actually connecting to the database/website. It calls direct website request urls and 
/// returns Json blob as a byte array which we encode into actual ascii text and then parse with Newtonsoft.Json
/// A lot of code is repeated. There might be some way to make it cleaner
/// </summary>

namespace LibrarinProject
{
    class LibraryConnector
    {
        private  WebClient connectorClient;
        public LibraryConnector()
        {
           this.connectorClient = new WebClient();
        }


        public User Login(String username, String password) //log in existing user
        {
            using (var WebClient = connectorClient){
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["username"] = username;
                dataToSend["password"] = password;//assigning data
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/librarylogin.php", dataToSend); //send data to database
                string result = System.Text.Encoding.UTF8.GetString(byteResult);
                try
                {
                    User currentUser = JsonConvert.DeserializeObject<User>(result); //deserialize json response into user object to keep track of who's logged in
                    return currentUser;
                }
                catch
                {
                    return null; //if the json deserialization fails that means that the login failed so it will return no current user logged in to the Login Form
                }
            }
        }
        public User Register(String username, String password, String role, String name, String email) //register new user
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["username"] = username;
                dataToSend["password"] = password;
                dataToSend["role"] = role;
                dataToSend["email"] = email;
                dataToSend["name"] = name; //assign all data
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/libraryregister.php", dataToSend); //send data to database
                string result = System.Text.Encoding.UTF8.GetString(byteResult);
                try
                {
                    User currentUser = JsonConvert.DeserializeObject<User>(result); //deserialize json response into user object to keep track of who's logged in
                    return currentUser;
                }
                    catch
                {
                    return null; //if the json deserialization fails that means that the login failed so it will return no current user logged in to the Login Form
                }
            }
        }
      public Boolean addBook(String title, String ISBN, String author)
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["Title"] = title;
                dataToSend["Author"] = author; 
                dataToSend["Status"] = "in"; //set book to checked in 
                dataToSend["ISBN"] = ISBN;
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/addBook.php", dataToSend); //send data to database
                string result = System.Text.Encoding.UTF8.GetString(byteResult);
                if (result.Equals("book already exists")) //check is book is already in database
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }
     public List<Book> getBooks()
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["nothing"] = "nothing";
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/getBooks.php", dataToSend); //this is actually an empty NameValueCollectoin just so I can finish the constructor
                string result = System.Text.Encoding.UTF8.GetString(byteResult);
                List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(result);
                return bookList;
            }
        }
      public void requestBook(string ISBN, string user_id)
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["ISBN"] = ISBN;
                dataToSend["user_id"] = user_id;
                dataToSend["Status"] = "out";
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/requestBook.php", dataToSend); //send the ISBN and change status to out
                byte[] byteResult1 = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/changeBookStatus.php", dataToSend); //assign the book to user who checked it out
                Console.WriteLine(byteResult1.ToString());

            }
        }
      public void changePassword(string newPassword, string username) {
                using (var WebClient = connectorClient)
                {
                    NameValueCollection dataToSend = new NameValueCollection();
                    dataToSend["username"] = username;
                    dataToSend["password"] = newPassword;
                    byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/changepassword.php", dataToSend);
                }
            } 
        public List<Book> getCheckedOutBooks(string user_id)
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["user_id"] = user_id;
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/getCheckedOutBooks.php", dataToSend); 
                string result = System.Text.Encoding.UTF8.GetString(byteResult);
                List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(result);
                return bookList;
            }
        }
        public void editBookTitle(String newTitle, String title)
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["Title"] = title;
                dataToSend["newTitle"] = newTitle;
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/editTitle.php", dataToSend);
            }
       }
        public void editBookAuthor(String newAuthor, String author)
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["Author"] = author;
                dataToSend["newAuthor"] = newAuthor;
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/editAuthor.php", dataToSend);
            }
        }
        public void editBookISBN(String newISBN, String ISBN)
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["ISBN"] = ISBN;
                dataToSend["newISBN"] = ISBN;
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/editISBN.php", dataToSend);
            }
        }
        public void returnBook(string ISBN)
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["ISBN"] = ISBN;
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/returnBook.php", dataToSend);
            }

        }
    }
}
