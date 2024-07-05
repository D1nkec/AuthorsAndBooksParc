using AuthorsAndBooksParc.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthorsAndBooksParc.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {

            var author1 = new Author { Id = 1, FirstName = "Dino", LastName = "Strejček" };
            var author2 = new Author { Id = 2, FirstName = "Dino", LastName = "Strejček" };
            var author3 = new Author { Id = 3, FirstName = "Dino", LastName = "Strejček" };
            var author4 = new Author { Id = 4, FirstName = "Dino", LastName = "Strejček" };
            var author5 = new Author { Id = 5, FirstName = "Dino", LastName = "Strejček" };


            var books = new List<Book>
            {
                new Book {Id = 1, Title = "Neka knjiga", Author = author1 },
                new Book {Id = 2, Title = "Neka knjiga2", Author = author1 },
                new Book {Id = 3, Title = "Neka knjiga3", Author = author1 },
                new Book {Id = 4, Title = "Neka knjiga4", Author = author1 },
                new Book {Id = 5, Title = "Neka knjiga5", Author = author1 },
            };

            return View(books);
        }
    }
}
