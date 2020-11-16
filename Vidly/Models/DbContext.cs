﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vidly.Models
{
    public class DbContext
    {
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Movie> Movies { get; set; }
            public DbSet<Genre> Genres { get; set; }
            public DbSet<MembershipType> MembershipType { get; set; }
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
}