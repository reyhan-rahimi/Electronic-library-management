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
            try
            {
                var search = db.books.Where(n => n.UserID == null).ToList();
                Console.WriteLine("list of exist book is:");
                Console.WriteLine(search);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
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
            try { 
            var search = db.users.Where(n => n.UserNationNumber == userModel.UserNationNumber).Include(x => x.rerbooks);
            var person = search.First();

            foreach(var item in person.rerbooks)
            {
                if (item.Time > 5)
                {
                    Console.WriteLine("you must return book");
                }
                else
                {
                    item.Time = 0;
                    Console.WriteLine("time increases");
                }
            }

            return true;
        }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
}
    }
}
