using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            //It's a disposable object, so we need to dispose this object properly
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {

            //Populate Manual Customer Records
            //var customers = GetCustomers();

            var customers = _context.Customers.ToList();

            return View(customers);
        }

        public ActionResult Details(int Id)
        {
            //Source from the manual populated data
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);

            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Brian Houston" },
                new Customer { Id = 2, Name = "Robert Ferguson" }
            };
        }
    }
}