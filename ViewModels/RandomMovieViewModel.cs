using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Filmoteka.Models;

namespace Filmoteka.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}