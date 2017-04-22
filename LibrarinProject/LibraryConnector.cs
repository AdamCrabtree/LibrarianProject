using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
                    return null;
                }
            }
        }
        public void Register(String username, String password, String role, String name) //register new user
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["username"] = username;
                dataToSend["password"] = password;
                dataToSend["role"] = role;
                dataToSend["name"] = name; //assign all data
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/libraryregister.php", dataToSend); //send data to database
                string result = System.Text.Encoding.UTF8.GetString(byteResult);
                Console.Write(result); //check if anything broke 
            }
        }
      public void addBook(String title, String ISBN, String author)
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
                Console.Write(result); //check if anything broke
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
      public void requestBook(string ISBN)
        {
            using (var WebClient = connectorClient)
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["ISBN"] = ISBN;
                dataToSend["Status"] = "out";
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/requestBook.php", dataToSend); //send the ISBN and change status to out
                string result = System.Text.Encoding.UTF8.GetString(byteResult);
                Console.Write(result);
      
            }
        }
    }
}
