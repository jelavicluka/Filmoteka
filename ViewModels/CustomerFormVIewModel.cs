using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Filmoteka.Models;

namespace Filmoteka.ViewModels
{
    public class CustomerFormVIewModel
    {
        public Customer Customer { get; set; }
        public List<MembershipType> MembershipTypes { get; set; }
    }
}