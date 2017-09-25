using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookRentals.Models;
using BookRentals.ViewModels;

namespace BookRentals.Controllers
{
    public class BooksController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetBooks();

            return View(movies);
        }

        private IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Name = "Stock Trading for Beginners" },
                new Book { Id = 2, Name = "The Drawing of the Three" }
            };
        }


        // -----------------
        // GET: Books/Random
        //public ActionResult Random()
        //{
        //    var book = new Book() { Name = "A Game of Thrones (Song of Ice and Fire)" };

        //    var customers = new List<Customer>
        //    {
        //        new Customer { Name ="Customer 1" },
        //        new Customer { Name ="Customer 2" }
        //    };

        //    var viewModel = new RandomBookViewModel
        //    {
        //        Book = book,
        //        Customers = customers
        //    };

        //    return View(viewModel);

        //    //return View(book);
        //    //return Content("Hello World!");
        //    //return HttpNotFound();
        //    //return new EmptyResult();
        //    //return RedirectToAction("Index", "Home");
        //    //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});

        //    //ViewData["Book"] = book; // magic string - ViewData - ViewDataDictionary us as dictionary with key value pair or use it as model property to work with an object
        //    //ViewBag.Book = book; // magic property - book added to the ViewBag.Book at runtime - no compile time safety
        //    //return View();
        //    //// dont use ViewData or ViewBag
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("id = " + id);
        //}

        //// books 
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}


        //[Route("books/published/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByPublishDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
        // -----------------

    }
}