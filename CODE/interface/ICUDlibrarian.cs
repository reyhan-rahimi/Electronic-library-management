using LibraryUnivercity.entity;
using LibraryUnivercity.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUnivercity.interfaces
{
    public interface ICUDlibrarian
    {
        public User CreateAccount(User user);
        public Books AddBook(Books book);
        public bool DeleteAccount(UserModel userModel);
        public bool DeleteBook(BookModel bookModel);
        public bool BorrowBook(UserModel userModel, BookModel bookModel);
        public bool ReturnBook(UserModel userModel, BookModel bookModel);
        public bool UpdateAccount(UserModel userModel, int choose);
        public bool CreateOrder(BookModel bookModel);
        public bool Count(int x);
        public bool identityconfirmation(LibrarianModel librarianModel);
    }
}
