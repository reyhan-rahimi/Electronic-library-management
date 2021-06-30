using LibraryUnivercity.entity;
using LibraryUnivercity.interfaces;
using LibraryUnivercity.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUnivercity.repository
{
    
    public class CUDuser :ICUDuser
    {
        public readonly DataBase db;
        public bool SearchBook(BookModel bookModel)
        {
            var search = db.books.Where(n => n.UserID == null).ToList();
            Console.WriteLine("list of exist book is:");
            Console.WriteLine(search);
            return true;
        }
        public bool ShowBorrowList(UserModel userModel)
        {
            try
            {
                var search = db.books.Where(n => n.UserID != null).Select(n => n);

                Console.WriteLine("list is :");

                foreach (var item in search)
                {
                    Console.WriteLine(item.BookName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public bool AddTime(UserModel userModel, BookModel bookModel)
        {
            //var search = db.users.Where(n => n.UserID == userModel.UserID).Include(x => x.rerbooks).First();
            var search = db.books.Where(n => n.BookCode == bookModel.BookCode).Include(x => x.UserID).First();
            var found = search.
            

        }
    }
}
