using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi2.Data.Model;

namespace WebApi2.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=order.yellowfin.com;Database=AspCore2010;Persist Security Info=True;User ID=adam;Password=Innovation1;MultipleActiveResultSets=True");
        }
    }
}
