using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUnivercity.entity
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions options) : base(options)
        {
        }

        public DataBase()
        {
        }
        public DbSet<Books> books { get; set; }
        public DbSet<Librarian> librarians { get; set; }
        public DbSet<User> users  { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(user =>
            {
                user.HasKey(x => x.UserID);
                user.Property(x => x.UserID).ValueGeneratedOnAdd();
            });
            builder.Entity<Books>(Book =>
            {
                Book.HasKey(x => x.BookID);
                Book.Property(x => x.BookID).ValueGeneratedOnAdd();
            });
            builder.Entity<Librarian>(librarians =>
            {
                librarians.HasKey(x => x.LibrarianID);
                librarians.Property(x => x.LibrarianID).ValueGeneratedOnAdd();
            });
        }
    }
}
