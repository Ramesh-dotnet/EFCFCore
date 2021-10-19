using EFCFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCFCore.Data
{
    //This will be our context class representing all our model classes with DB
    public class ERPContext : DbContext
    {
        public ERPContext(DbContextOptions<ERPContext> options) : base(options)
        {

        }
        //Dbset always for CRUD operations
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
