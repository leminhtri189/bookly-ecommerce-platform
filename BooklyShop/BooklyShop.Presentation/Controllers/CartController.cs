using BooklyShop.Presentation.Infrastructure;
using BooklyShop.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooklyShop.Presentation.Controllers
{
    public class CartController : Controller
    {
        private const string CartSessionKey = "CART";

        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObject<List<CartItemViewModel>>(CartSessionKey) ?? new List<CartItemViewModel>();

            var lines = new List<CartLineViewModel>();
            foreach (var item in cart)
            {
                var book = SampleBookCatalog.GetById(item.BookId);
                if (book is null)
                {
                    continue;
                }

                lines.Add(new CartLineViewModel
                {
                    Book = book,
                    Quantity = item.Quantity
                });
            }

            var vm = new CartViewModel { Lines = lines };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int bookId, int quantity)
        {
            var cart = HttpContext.Session.GetObject<List<CartItemViewModel>>(CartSessionKey) ?? new List<CartItemViewModel>();
            var item = cart.FirstOrDefault(x => x.BookId == bookId);

            if (item is not null)
            {
                if (quantity <= 0)
                {
                    cart.Remove(item);
                }
                else
                {
                    item.Quantity = quantity;
                }

                HttpContext.Session.SetObject(CartSessionKey, cart);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remove(int bookId)
        {
            var cart = HttpContext.Session.GetObject<List<CartItemViewModel>>(CartSessionKey) ?? new List<CartItemViewModel>();
            cart.RemoveAll(x => x.BookId == bookId);
            HttpContext.Session.SetObject(CartSessionKey, cart);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Clear()
        {
            HttpContext.Session.Remove(CartSessionKey);
            return RedirectToAction(nameof(Index));
        }
    }
}
