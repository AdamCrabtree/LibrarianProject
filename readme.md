## Synopsis

This  is a full library system written in C# with Windows Forms allowing users to log in, check out books and get notifications when the books are due through email. 
Administrators can add/edit books and return books along with checking 
them out. The root administrator can create new users along with all previous privileges.

## Code Example

All code is separated into separate user forms and specific connection classes. In order to work with books we have a specific static class (BookBinders)
that handles all use of books with the database. For example:

static public ArrayList BookBinders.getBooksFromDatabase() 

returns a list of all possible books in the database regardless of status and is used multiple times throughout the project.


-------------------------------------
In order to work with users we have a specific static class (UserBinder)
that handles all use of users with the database. For example:

static public Tuple<User, bool> UserBinder.AttemptLogin(string Username, string Password) 

attempts to login to the database and returns the specific user logged in and whether it was successful or not. 

## Motivation

In order to learn C# with WPF, mySQL, PHP, and RESTful web design. This program could also be used in a real environment for library systems.

## Installation

In order to build the project you need to have a visual studio installation and just pull it or clone/download. In order to run the project though
you will either need to change the start up form with an existing user, but you will encounter errors, or login with the root account and add your own user for testing.

## Usage And Screenshots

Login Form: Just enter username and password

![alt text](https://cloud.githubusercontent.com/assets/6658898/26036190/216274c6-38a7-11e7-842e-123c80588e33.PNG)
--------------------------



Main Navigation form: Go to different parts of the program. Certain buttons only show up if you're root.
![alt text](https://cloud.githubusercontent.com/assets/6658898/26036191/223f47a2-38a7-11e7-8403-8326b12b3bb2.PNG)


-------------------

Request Book Form: A list of all books in the database. Click a specific book and then click request. Most of the books currently in the database don't actually exist but in a real world scenario that can be changed.

![alt text](https://cloud.githubusercontent.com/assets/6658898/26036192/22f0bb5e-38a7-11e7-81c4-67e8345f4b5d.PNG)


----------------


Register User Form: Only root can add new users. Other than that registration is rather straightforward with a username, password, name, and email. 

![alt text](https://cloud.githubusercontent.com/assets/6658898/26036193/2397bad0-38a7-11e7-90d1-c4e9e277263a.PNG)


-------------------------

## License

MIT License
