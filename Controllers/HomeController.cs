using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineBooks.Models;
using OnlineBooks.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBooksRepository _repository;
        public int PageSize = 5;
        public HomeController(ILogger<HomeController> logger, IBooksRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        //returns view for index with the books 
        public IActionResult Index(int page = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books
                .OrderBy(p => p.BookId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                Paginginfo = new Paginginfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Books.Count()
                }
            });
        }
        //gets the privacy page

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
