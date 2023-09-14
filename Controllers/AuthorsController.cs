using LibraryProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryProj.Controllers
{
    public class AuthorsController : Controller
    {
        private LibraryContext _context { get; set; }
        public AuthorsController(LibraryContext ctx) => _context = ctx;
        public IActionResult Index()
        {
            var authors = _context.Authors.ToList();
            return View(authors);
        }
    }
}
