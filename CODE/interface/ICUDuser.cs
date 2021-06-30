using LibraryUnivercity.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUnivercity.interfaces
{
    public interface ICUDuser
    {
        public BookModel SearchBook(BookModel bookModel);
        public BookModel ShowBorrowList(UserModel userModel);
        public bool AddTime(UserModel userModel, BookModel bookModel);
    }
}
