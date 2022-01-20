using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class DataSource01Context : DbContext
    {
        public DataSource01Context(DbContextOptions<DataSource01Context> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<ProductTypes> ProductTypes { get; set; }
    }
}
