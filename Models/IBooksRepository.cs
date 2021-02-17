using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBooks.Models
{
    //change to Interface to create a template, meant to be inherited base structure
    //we will take the repository and implement it into a class
    public interface IBooksRepository
    {    //IQueryable makes it able to be queried from
        IQueryable<Book> Books { get; }
    }
}
