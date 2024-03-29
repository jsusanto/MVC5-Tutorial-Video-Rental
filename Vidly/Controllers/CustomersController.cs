﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModel;
using System.Data.Entity.Validation;
using System.Runtime.Caching;

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

            //Comment out because the list of customers dislayed from Ajax JQuery
            //var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            //return View(customers);

            return View();
        }

        public ActionResult IndexCache()
        {
            //Example of Caching Data
            if (MemoryCache.Default["Genre"] == null)
                MemoryCache.Default["Genre"] = _context.Genres.ToList();

            var genres = MemoryCache.Default["Genre"] as IEnumerable<Genre>; 

            return View(genres);
        }
        public ActionResult Details(int Id)
        {
            //Source from the manual populated data
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);

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

        [HttpPost]
        [ValidateAntiForgeryToken] //To Perform / Activate the anti forgery token checking
        public ActionResult Save(Customer customer)
        {
            //To activate validation
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            };

            if(customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                //Will be updated according to key and pair value data recommended by Microsoft
                //Drawback: open the security issues
                //TryUpdateModel(customerInDb);

                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }

            try
            {
                _context.SaveChanges();
            }
            catch(DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int Id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }
    }
}