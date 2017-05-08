using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentalShowcase.Models;

namespace RentalShowcase.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}