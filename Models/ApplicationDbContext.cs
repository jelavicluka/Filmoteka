using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;

namespace Filmoteka.Models
{
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public DbSet<Customer> Customers { get; set; }

            public DbSet<Movies> Movies { get; set; }

            public DbSet<MembershipType> MembershipTypes { get; set; }

            public DbSet<Genre> Genres { get; set; }

            public DbSet<Rental> Rentals { get; set; }

            public ApplicationDbContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }

            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }
        }
}