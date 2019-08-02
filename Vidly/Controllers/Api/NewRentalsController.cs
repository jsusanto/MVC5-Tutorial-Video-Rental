using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //Why using .single? It's for internal use and We're assuming that the customer will send the right customer ID
            /*
             if We want to use this API for external use then we need to use .SingleOrDefault and check whether it's null
             if ( customer == null )
                 return BadRequest('Invalid Customer ID');
             */
            var customer = _context.Customers
                .Single(c => c.Id == newRental.CustomerId);

            //Translate to SQL statement as select * from [table] where id in ()
            var movies = _context.Movies
                .Where(m => newRental.MovieIds.Contains(m.Id));

            foreach(var movie in movies)
            {
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
