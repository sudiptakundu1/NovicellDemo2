using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class DataSource02Context : DbContext
    {
        public DataSource02Context(DbContextOptions<DataSource02Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Products> Products { get; set; }
    }
}
