using LibraryUnivercity.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUnivercity.interfaces
{
    public interface ICUDuser
    {
        public bool SearchBook(BookModel bookModel);
        public bool ShowBorrowList(UserModel userModel);
        public bool AddTime(UserModel userModel, BookModel bookModel);
        public bool identityconfirmation(UserModel userModel);
    }
}
