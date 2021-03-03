using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBooks.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public Paginginfo Paginginfo { get; set; }
        //this needs to be the same as the currentcategory on the other file
        public string CurrentCategory { get; set; }
    }
}
