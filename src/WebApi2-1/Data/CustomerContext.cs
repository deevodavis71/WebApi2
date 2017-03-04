using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2_1.Data.Model;

namespace WebApi2_1.Data
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("WebApi2-1");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=order.yellowfin.com;Database=AspCore2010;Persist Security Info=True;User ID=adam;Password=Innovation1;MultipleActiveResultSets=True",
                                        x => x.MigrationsHistoryTable (HistoryRepository.DefaultTableName, "WebApi2-1"));
        }
    }
}
