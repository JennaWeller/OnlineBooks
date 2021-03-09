using Microsoft.AspNetCore.Mvc;
using OnlineBooks.Models;
namespace OnlineBookstore.Components
{
    //inherits from view component
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
