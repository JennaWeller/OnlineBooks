using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//EF books repository
namespace OnlineBooks.Models
{
    //an entity framework for our repository
    public class EFBooks : IBooksRepository
    {

        private BookDBContext _context;
        //constructor, pass in type of context you're wanting
        public EFBooks(BookDBContext context)
        {
            _context = context;
        }
        //the IQueryable part makes it so it can be queried from
        public IQueryable<Book> Books => _context.Books;
    }
}
