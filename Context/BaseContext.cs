using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using ToyStoreApplication.Models;

namespace ToyStoreApplication.Context
{
    public abstract class BaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("data source=DarshiL7\\SQLEXPRESS;initial catalog=ToyStore;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }


        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Plant> Plants { get; set; }

        public DbSet<Toy> Toys { get; set; }

        public DbSet<ToyType> ToyTypes { get; set; }
    }
}
