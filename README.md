# Console Banking Application

To run:

```
git clone https://github.com/DSchroederOSU/BankingConsoleApp.git .
```
then run:

```
dotnet run
```

This will bring up the main application window that looks like:

![alt text](https://github.com/DSchroederOSU/BankingConsoleApp/blob/master/assets/menu.png)


From here the user is able to select menu options by typing the number corresponding to the menu item (i.e. 1, 2, 3)

Upon successful registration the user may log in with his/her new credentials.

When logged in, the user is prompted with a new menu:

![alt text](https://github.com/DSchroederOSU/BankingConsoleApp/blob/master/assets/logmenu.png)

Now the user may make changes to his/her account by selecting menu items by typing the corresponding number and hitting enter. 

## Notes
Multiple Users may register and use the app at once. The app keeps track of the current "logged in" user while maintaining data of all users in a List<User> called RegisteredUsers.

There is minimal input validation set up for username and password requirements. This may be implemented later if needed. The application does validate that the user is registering with a unique username.