# Console Banking Application
## Assignment Criteria
You have been tasked with writing the world’s greatest banking ledger. Please code a solution that can perform the following workflows through a console application (accessed via the command line):

- Create a new account
- Login
- Record a deposit
- Record a withdrawal
- Check balance
- See transaction history
- Log out
For additional credit, you may implement this through a web page. They don’t have to run at the same time, but if you would like to do that, feel free.

C# is preferred but not required. Use whatever frameworks/libraries you wish, and just make sure they are included or available via via NuGet/npm/etc. Please use a temporary memory store (local cache) instead of creating an actual database, and don't spend much time on the UI (unless you love doing that).

## Installation and Running
To run:

```
git clone https://github.com/DSchroederOSU/BankingConsoleApp.git .
```
then run:

```
npm install
npm run build
npm run start
```
This will install "dotnet-2.0.0" and "dotnet-sdk-2.0.0" and allow the user to build and run the c# project.

After running "npm run start" the program will bring up the main application window that looks like:

![alt text](https://github.com/DSchroederOSU/BankingConsoleApp/blob/master/assets/menu.png)


From here the user is able to select menu options by typing the number corresponding to the menu item (i.e. 1, 2, 3)

Upon successful registration the user may log in with his/her new credentials.

When logged in, the user is prompted with a new menu:

![alt text](https://github.com/DSchroederOSU/BankingConsoleApp/blob/master/assets/logmenu.png)

Now the user may make changes to his/her account by selecting menu items by typing the corresponding number and hitting enter. 

## Notes
Multiple Users may register and use the app at once. The app keeps track of the current "logged in" user while maintaining data of all users in a List\<User\> called RegisteredUsers.

There is minimal input validation set up for username and password requirements. This may be implemented later if needed. The application does validate that the user is registering with a unique username.