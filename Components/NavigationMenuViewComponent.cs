﻿using Microsoft.AspNetCore.Mvc;
using OnlineBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBooks.Components
{   //navigation under the component
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBooksRepository repository;
        //parameters of book repository
        public NavigationMenuViewComponent(IBooksRepository r)
        {
            repository = r;

        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));

        }

    }
}
