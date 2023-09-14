using LibraryProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryProj.Controllers
{
    public class BooksController : Controller
    {
        private LibraryContext _context { get; set; }
        public BooksController(LibraryContext ctx) => _context = ctx;
        public IActionResult Index()
        {
            var books = _context.Books.Include(b => b.Author).ToList();
            return View(books);
        }
    }
}
