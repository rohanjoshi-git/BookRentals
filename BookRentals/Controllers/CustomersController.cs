using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookRentals.Models;

namespace BookRentals.Controllers
{
    public class CustomersController : Controller
    {

        // Start- Entity Framework
        //private ApplicationDbContext _context; // DbContext - disposable object

        //public CustomerController()
        //{
        //    _context = new ApplicationDbContext();
        //}

        //protected override void Dispose(bool disposing) // override --> dispose --> tabtab
        //{
        //    _context.Dispose();
        //}
        // End - Entity Framework

        // GET: Customer
        public ViewResult Index()
        {

            var customers = GetCustomers();

            //var customers = _context.Customers; // Deferred Execution
            return View(customers);
        }


        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
               new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}