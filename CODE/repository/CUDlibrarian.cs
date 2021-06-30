using LibraryUnivercity.entity;
using LibraryUnivercity.interfaces;
using LibraryUnivercity.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUnivercity.repository
{
    public class CUDlibrarian : ICUDlibrarian
    {
        public readonly DataBase db;
        public CUDlibrarian(DataBase DB)
        {
            this.db = DB;
        }
        public User CreateAccount(User user)
        {
            User p = new User()
            {
                UserBirthday = new DateTime(2020, 3, 11),
                UserName = user.UserName,
                UserLastName = user.UserLastName,
                UserNationNumber = user.UserNationNumber
            };

            db.users.Add(p);
            db.SaveChanges();

            return p;
        }
        public Books AddBook(Books book)
        {
            Books bo = new Books()
            {
                BookCode = book.BookCode,
                BookWriter=book.BookWriter,
                BookName = book.BookName

            };
            db.Add(bo);
            db.SaveChanges();

            return bo;
        }
        public bool DeleteAccount(UserModel userModel)
        {
            var search = db.users.Where(n => n.UserNationNumber == userModel.UserNationNumber);
            var found = search.First();
            int c = search.Count();
            if (!Count(c))
            {
                Console.WriteLine("try again");
                return false;
            }
            else
            {
                db.Remove(found);
                db.SaveChanges();

                return true;
            }

        }
        public bool DeleteBook(BookModel bookModel)
        {
            var search = db.books.Where(n => n.BookName == bookModel.BookName);
            var found = search.First();
            int c = search.Count();
            if (!Count(c))
            {
                Console.WriteLine("try again");
                return false;
            }
            else
            {
                db.Remove(found);
                db.SaveChanges();

                return true;
            }
        }
        public bool BorrowBook(UserModel userModel, BookModel bookModel)
        {

        }
        public bool ReturnBook(UserModel userModel, BookModel bookModel)
        {

        }
        public bool UpdateAccount(UserModel userModel,int choose)
        {
            bool result;
            int k = choose;
            switch (k)
            {
                case 0:
                    Console.WriteLine("update name");
                    var search = db.users.Where(n => n.UserNationNumber == userModel.UserNationNumber);
                    var found = search.First();
                    int c = search.Count();
                    if (!Count(c))
                    {
                        Console.WriteLine("try again");
                        return false;
                    }
                    else
                    {
                        found.UserName = userModel.UserName;
                        db.SaveChanges();
                        return true;
                    }
                    break;

                case 1:
                    Console.WriteLine("updare lastname");
                    var search1 = db.users.Where(n => n.UserNationNumber== userModel.UserNationNumber);
                    var found1 = search1.First();
                    int c1 = search1.Count();
                    if (!Count(c1))
                    {
                        Console.WriteLine("try again");
                        return false;
                    }
                    else
                    {
                        found1.UserLastName = userModel.UserLastName;
                        db.SaveChanges();
                        return true;
                    }
                    break;

                default:
                    Console.WriteLine("update birthday");
                    var search2 = db.users.Where(n => n.UserNationNumber == userModel.UserNationNumber);
                    var found2 = search2.First();
                    int c2 = search2.Count();
                    if (!Count(c2))
                    {
                        Console.WriteLine("try again");
                        return false;
                    }
                    else
                    {
                        found2.UserBirthday = new DateTime(2019, 4, 19);
                        db.SaveChanges();
                        return true;
                    }
                    break;
            }
           
        }
 
    public bool CreateOrder(BookModel bookModel)
        {

        }
        public bool Count(int x)
        {
            if (x > 1)
            {
                Console.WriteLine("erorre");
                return false;
            }
            else if (x < 1)
            {
                Console.WriteLine("not found");
                return false;
            }
            else
                return true;

        }
    }
}
