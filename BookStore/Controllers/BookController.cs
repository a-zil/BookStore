using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public IActionResult GetAllBooks()
        {
            return View();
        }

        public IActionResult GetBook(int id)
        {
            return View();
        }

        public IActionResult SearchBooks(string title, string author)
        {
            return View();
        }
    }
}
