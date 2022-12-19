using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Filmoteka.Models;

namespace Filmoteka.ViewModels
{
    public class MovieFormViewModel
    {
        public Movies Movies { get; set; }
        public List<Genre> Genre { get; set; }
    }
}