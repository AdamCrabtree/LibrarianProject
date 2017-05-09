## Synopsis

This  is a full library system written in C# with WPF allowing users to log in, check out books and get notifications when the books are due through email. 
Adminstrators can add/edit books and return books along with checking 
them out. The root administrator is allowed to create new users along with all previous privelges.

## Code Example

All code is seperated into seperate user forms and specific connection classes. In order to work with books we have a specific static class (BookBinders)
that handles all use of books with the database. For example:

BookBinders.getBooksFromDatabase() 

returns a list of all possible books in the database regardless of status and is used multiple times throughout the project.


-------------------------------------
In order to work with users we have a specific static class (UserBinder)
that handles all use of users with the database. For example:

UserBinder.AttemptLogin(string Username, string Password) 


attempts to login to the database and returns the specific user logged in for future use for permissoins and determining what books are currently checked out. 

## Motivation

In order to learn C# with WPF, mySQL, PHP, and RESTful web design. This program could also be used in a real enviornment for library systems.

## Installation

In order to build the project you need to have a visual studio installation and just pull it or clone/download. In order to run the project though
you will either need to change the start up form with an existing user, but you will encouter errors, or login with the root account and add your own user for testing.

## License

MIT License
