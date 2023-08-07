Summary
The "Lab8_Library" is a C# console application that simulates a lending library. Users can interact with the library by adding books, borrowing books, returning books, searching for books, and viewing all available books.

Visuals
Phil's Lending Library
Hello, welcome to the Library!
Press the corresponding key to continue.
Add a Book [1]
Borrow a Book [2]
Return a Book [3]
Search for a book [4]
View all Books [5]

#####################################
5
Baki
Bastard!
Misfit of Demon King Academy
#####################################
Press the corresponding key to continue.
Add a Book [1]
Borrow a Book [2]
Return a Book [3]
Search for a book [4]
View all Books [5]

#####################################
2
Which book would you like to borrow?
2
#####################################
Press the corresponding key to continue.
Add a Book [1]
Borrow a Book [2]
Return a Book [3]
Search for a book [4]
View all Books [5]

#####################################
5
Baki
Bastard!
Misfit of Demon King Academy
#####################################
Press the corresponding key to continue.
Add a Book [1]
Borrow a Book [2]
Return a Book [3]
Search for a book [4]
View all Books [5]

#####################################
1
Please enter the Title of the book
39 Clues
Please enter the Author of the book
Spoony
#####################################
Press the corresponding key to continue.
Add a Book [1]
Borrow a Book [2]
Return a Book [3]
Search for a book [4]
View all Books [5]

#####################################
5
Baki
Bastard!
Misfit of Demon King Academy
39 Clues
#####################################
Press the corresponding key to continue.
Add a Book [1]
Borrow a Book [2]
Return a Book [3]
Search for a book [4]
View all Books [5]

#####################################

How to Use
Clone the repository or download the code files to your local machine.

Open the solution file in a C# IDE (e.g., Visual Studio).

Compile and run the program.

The program will display the library name in a typewriter-style animation and a welcome message.

You will be presented with a menu of options:

Press [1] to add a book to the library.
Press [2] to borrow a book from the library.
Press [3] to return a borrowed book to the library.
Press [4] to search for a book in the library.
Press [5] to view all available books in the library.
Choose the desired option by entering the corresponding number.

Adding a Book [1]
Enter the title of the book when prompted.
Enter the author of the book when prompted.
The book will be added to the library's collection.
Borrowing a Book [2]
Enter the title of the book you want to borrow when prompted.
If the book is available in the library, it will be borrowed and added to your backpack.
Returning a Book [3]
The program will display the books currently in your backpack.
Select the book you want to return by entering its index.
The book will be returned to the library's collection.
Searching for a Book [4]
Enter the title of the book you want to search for when prompted.
If the book is in the library's collection, its details will be displayed.
Viewing All Books [5]
The program will display a list of all the books available in the library.
Other Details
The application uses a Library class to manage the collection of books.
The application uses a Book class to represent individual books.
The borrowed books are stored in a Backpack class to simulate user borrowing.
The program uses a while loop to keep the menu running until the user decides to exit.
The code is written in C# and targets the .NET platform.