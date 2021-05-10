
# in the name of GOD
## Scenario of Lesson project scenario of software engineering laboratory
## Title : Electronic library managment
teacher : mr mostafa alinaghi por
date : 6.may.2021
members:
* reyhane hassan rahimi
* raziye kamali


### The purpose of the scenario:

Since today managing libraries manually is impossibl idea and inefficient, it's worth designing a system that can be overcome in addition to Disadvantages of manual systems, activities inside the library using tools Improved like the internet and computers. 

### usecases of this system:

1. adding a membership
2. canceling a membership
3. borrowing existing books
4. Return of borrowed books
5. Change member user information 
6. Registering a book order 
7. Extending the book deadline 

### Persons involved:

1. Librarians 
2. members

### Identify system entities :

Each entity contains components. In the case of this system, the components of the book, member, and librarian are as follows:


* book (Book ID , Book Name , Writer Name)
* Librarians (Librarians ID , Librarianse Naame , Librarianse Lastname)
* Meember (Member ID , Name , Lastname , NationId , date of bitrthday , job , addres , email)

### Usecase 1:
### adding a membership

1. stare
2. refrense to library
3. membership request with personal doucuments
4. Librarians logs in system
5. import username and password on Respective box
6. if information is correct log in
7. else show massage "try again"
8. after log in:
9. import member's information
10. if this informathin was exist :
* show massage "this account is exist"
11. else system chacks information 
12. if evrything is correct show massage "success"
13. log out if not to be another request
14. if was another request :
*  call requests Routine 
15. end

### Usecase 2:
### canceling a membership

1. stare
2. refrense to library
3. Librarians logs in system
4. import username and password on Respective box
5. if information is correct log in
6. else show massage "try again"
7. after log in:
8. import member's information
9. account will be delete
10. log out if not to be another request
11.  if was another request :
*  call requests Routine 
12. end

### Usecase 3:
### borrowing existing books

1. start
2. log in system
3. import username and password
4. log in if password is correct 
5. if password is not correct :
* have 3 chanse to import correct password
* if after 3 time password is not correct user can not log in until 1 hour
6. if password was correct , import book information
7. if book is not exist in library :
* show message "the book is not exist"
8. if book is exist:
* show bookid
9. user logs out
10. user goes to librarianse
11. Librarians logs in system
12. import username and password on Respective box
13. if information is correct log in
14. else show massage "try again"
15. after log in:
16. The librarian registers the book as a borrow to the user.
17. log out if not to be another request
18.  if was another request :
*  call requests Routine 
19. end

### Usecase 4:
### Return of borrowed books

1. stare
2. refrense to library
3. Librarians logs in system
5. import username and password on Respective box
6. if information is correct log in
7. else show massage "try again"
8. after log in:
9. call Routine of return book
10. log out if not to be another request
11.  if was another request :
*  call requests Routine 
12. end

### Usecase 5:
### Change member user information

1. stare
2. refrense to library
3. Librarians logs in system
5. import username and password on Respective box
6. if information is correct log in
7. else show massage "try again"
8. after log in:
9. call Update information Routine
10. import user information
11. change user information
12. log out if not to be another request
13. if was another request :
*  call requests Routine 
14. end

### Usecase 6:
### Registering a book order 

1. start
2. Librarians logs in system
3. import username and password on Respective box
4. if information is correct log in
5. else show massage "try again"
6. after log in:
7. import name of  books that were required
8. create PDF file of book's name
9. log out if not to be another request
10. if was another request :
*  call requests Routine 
11. end

### Usecase 7:
### Extending the book deadline


1. start
2. log in system
3. import username and password
4. log in if password is correct 
5. if password is not correct :
* have 3 chanse to import correct password
* if after 3 time password is not correct user can not log in until 1 hour
6. call Extension routine
7. import book information
8. book will be Extended for 5 daays
9. log out of sesyem
10. end