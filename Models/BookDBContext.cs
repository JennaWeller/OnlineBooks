using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBooks.Models
{
    //query db CRUD
    public class BookDBContext : DbContext
    {
        //  inherits from the base 
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

    }
}
