using System;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Net;


namespace LibrarianProject
{
    /// <summary>
    ///controls anything to do with users including registering logging in an editing passwords
    ///the methods that actually login and attempt to login are two different things might want to refactor that into one function
    ///</summary>
    public static class UserBinder
    {

        static public Tuple<User, bool> attemptLogin(String username, String password)
        {
            User currentUser = Login(username, password);
            try
            {
                if (currentUser.success.Equals("true")) //request goes through correctly and assigns to currentUser
                {
                    return Tuple.Create(currentUser, true); //return the user and success of the program
                }
                else
                {
                    return Tuple.Create(currentUser, false);
                }
            }
            catch
            {
                return Tuple.Create(currentUser, false);
            }
        }
        static public User Login(String username, String password) //log in existing user
        {
            using (var WebClient = new WebClient())
            {
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
        static public User Register(String username, String password, String role, String name, String email) //register new user
        {
            using (var WebClient = new WebClient())
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
        static public void changePassword(string newPassword, string username)
        {
            using (var WebClient = new WebClient())
            {
                NameValueCollection dataToSend = new NameValueCollection();
                dataToSend["username"] = username;
                dataToSend["password"] = newPassword;
                byte[] byteResult = WebClient.UploadValues("https://toledopickupapp.000webhostapp.com/changepassword.php", dataToSend);
            }
        }

    }

}
