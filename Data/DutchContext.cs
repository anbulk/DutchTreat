﻿using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchContext : DbContext
    {

        public DutchContext(DbContextOptions<DutchContext> options):base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected void OnCreatingModel(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>()
                .HasData(new Order()
                {
                    Id= 1,
                    OrderDate =DateTime.UtcNow,
                    OrderNumber ="12345"
                });
        }

    }
}
