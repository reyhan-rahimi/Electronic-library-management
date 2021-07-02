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
    public class CUDlibrarian : ICUDlibrarian
    {
        public readonly DataBase db;
        public CUDlibrarian(DataBase DB)
        {
            this.db = DB;
        }
        public User CreateAccount(User user)
         {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public Books AddBook(Books book)
        {
            try
            {
                Books bo = new Books()
                {
                    BookCode = book.BookCode,
                    BookWriter = book.BookWriter,
                    BookName = book.BookName

                };
                db.Add(bo);
                db.SaveChanges();

                return bo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public bool DeleteAccount(UserModel userModel)
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public bool DeleteBook(BookModel bookModel)
            {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool BorrowBook(UserModel userModel, BookModel bookModel)
        {
            try
            {
                var search = db.users.Where(n => n.UserNationNumber == userModel.UserNationNumber).First();
                var searchBook = db.books.Where(n => n.BookCode == bookModel.BookCode).First();
                search.rerbooks.Add(searchBook);
                searchBook.UserID = userModel.UserID;
                db.Update(search);
                db.Update(searchBook);
                return true;
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public bool ReturnBook(UserModel userModel, BookModel bookModel)
        {
            try
            {
                var search = db.users.Where(n => n.UserNationNumber == userModel.UserNationNumber).Include(x => x.rerbooks).First();
                var found = search.rerbooks.Where(x=>x.BookCode==bookModel.BookCode).First();
                found.UserID = null;
                found.Time = 0;
                db.Update(found);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool UpdateAccount(UserModel userModel,int choose)
        {
            try { 
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
 
    public bool CreateOrder(BookModel bookModel)
    {
            try
            {
               


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
    }
        public bool Count(int x)
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
