﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///controls login is currently called from loginform returns tuples of User and a boolean whether it succeeded or not. This is just a stateless class so I should 
///make it static
///</summary>

namespace LibrarianProject
{
    public static class LoginModel
    {
        static public Tuple<User, bool> attemptLogin(String username, String password)
        {
            LibraryConnector myConnection = new LibraryConnector();
            User currentUser = myConnection.Login(username, password);
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
    }
}