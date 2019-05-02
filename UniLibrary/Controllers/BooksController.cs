using DataContext.Entities;
using Repository.Abstract;
using System.Web.Mvc;

namespace UniLibrary.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookRepository bookRepo;

        public BooksController(IBookRepository bookRepo)
        {
            this.bookRepo = bookRepo;
        }
        // GET: Books
        public ActionResult Index()
        { 
            return View();
        }

        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                //create add method in service and repo
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }
    }
}