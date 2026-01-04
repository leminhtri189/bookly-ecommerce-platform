using BooklyShop.Presentation.Infrastructure;
using BooklyShop.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooklyShop.Presentation.Controllers
{
    public class BooksController : Controller
    {
        private const string CartSessionKey = "CART";

        public IActionResult Index()
        {
            var books = SampleBookCatalog.GetAll();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = SampleBookCatalog.GetById(id);
            if (book is null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart(int id, int quantity = 1)
        {
            if (quantity < 1)
            {
                quantity = 1;
            }

            var book = SampleBookCatalog.GetById(id);
            if (book is null)
            {
                return NotFound();
            }

            var cart = HttpContext.Session.GetObject<List<CartItemViewModel>>(CartSessionKey) ?? new List<CartItemViewModel>();

            var existing = cart.FirstOrDefault(x => x.BookId == id);
            if (existing is null)
            {
                cart.Add(new CartItemViewModel { BookId = id, Quantity = quantity });
            }
            else
            {
                existing.Quantity += quantity;
            }

            HttpContext.Session.SetObject(CartSessionKey, cart);
            return RedirectToAction("Index", "Cart");
        }
    }
}
