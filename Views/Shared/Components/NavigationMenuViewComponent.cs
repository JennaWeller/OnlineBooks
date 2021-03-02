using Microsoft.AspNetCore.Mvc;
using OnlineBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBooks.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBooksRepository repository;
        public NavigationMenuViewComponent(IBooksRepository r)
        {
            repository = r;

        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectCategory = RouteData?.Values["category"];
            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));

        }

    }
}