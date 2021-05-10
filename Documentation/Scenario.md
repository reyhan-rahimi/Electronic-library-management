#به نام خدا
##**سناریو پروژه درس آزمایشگاه **مهندسی نرم افزار
بهار 1400
استاد : مصطفی علی نقی پور


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
*  call requests
15. end